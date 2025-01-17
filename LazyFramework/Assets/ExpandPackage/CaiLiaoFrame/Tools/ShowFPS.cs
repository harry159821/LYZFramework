using UnityEngine;
using System.Collections;

namespace XuYiGame
{
    public class ShowFPS : MonoBehaviour
    {
        public float f_UpdateInterval = 0.5F;

        private float f_LastInterval;

        private int i_Frames = 0;

        private float f_Fps;

        bool isShow;
        void Start()
        {
            //Application.targetFrameRate=60;
            f_LastInterval = Time.realtimeSinceStartup;
            i_Frames = 0;
        }

        void OnGUI()
        {
            if (isShow)
                GUI.Label(new Rect(0, 50, 300, 300), "FPS:" + f_Fps.ToString("f2"));
        }
        int flag = 0;
        void Update()
        {
            ++i_Frames;
            if (Time.realtimeSinceStartup > f_LastInterval + f_UpdateInterval)
            {
                f_Fps = i_Frames / (Time.realtimeSinceStartup - f_LastInterval);
                i_Frames = 0;
                f_LastInterval = Time.realtimeSinceStartup;
            }
            if (Input.GetKeyUp(KeyCode.T))
            {
                if (flag == 0)
                {
                    isShow = true;
                    flag = 1;
                    return;
                }
                if (flag == 1)
                {
                    isShow = false;
                    flag = 0;
                    return;
                }
            }
        }
    }
}