using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    public float velocity = 0.35f;

    //每一步蛇头移动距离

    public int step;

    //x轴蛇头移动增量

    private int x;

    //y轴蛇头移动增量

    private int y;



    private void Start()

    {

        //初始化，让蛇头可以向上移动

        x = 0;

        y = step;

        //InvokeRepeating等待0秒，然后每隔velocity时间调用Move方法

        InvokeRepeating("Move", 0, velocity);

    }



    private void Update()

    {

        //虚拟轴控制移动

        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        //Input.GetKeyDown键按下瞬间

        if (Input.GetKeyDown(KeyCode.Space))

        {

            //CancelInvoke先取消之前的InvokeRepeating命令

            CancelInvoke();

            //将间隔调用“Move”方法的时间减小，则蛇移动变快

            InvokeRepeating("Move", 0, velocity - 0.2f);

        }

        //Input.GetKeyUp键抬起瞬间

        if (Input.GetKeyUp(KeyCode.Space))

        {

            CancelInvoke();

            InvokeRepeating("Move", 0, velocity);

        }

        //如果此时y = -step说明蛇正在向下移动，为了防止蛇目前在向下移动，突然向上移动，加y != -step判断，以下同理

        {

            //设置当头上下左右移动的时候，蛇头的方向和移动方向一致，以下同理

            //Quaternion代表四元数，identity表示初始旋转角度，可理解为new Vector(0,0,0)

            gameObject.transform.localRotation = Quaternion.identity;

            //设置蛇的移动方向，x = 0,y = step说明蛇头在Y轴向上移动，以下同理

            x = 0;

            y = step;

        }

        if (v < 0 && y != step)

        {

            //Quaternion.Euler将欧拉角转化为四元数，需要注意欧拉角要与移动方向匹配

            gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));

            x = 0;

            y = -step;

        }

        if (h < 0 && x != step)

        {

            gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));

            x = -step;

            y = 0;

        }

        if (h > 0 && x != -step)

        {

            gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -90));

            x = step;

            y = 0;

        }

    }



    void Move(Vector3 headPos)

    {

        //获取当前蛇头移动的局部坐标

        headPos = gameObject.transform.localPosition;

        //将蛇头当前的移动位置加上x轴和y轴的移动增量，实现蛇头的移动

        gameObject.transform.localPosition = new Vector3(headPos.x + x, headPos.y + y, 0);

    }
}




