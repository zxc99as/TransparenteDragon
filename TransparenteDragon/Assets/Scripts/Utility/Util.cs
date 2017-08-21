using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Utility
{
   class DebugUtil
   {
        // 디버그용 사각형 박스를 그립니다.
        public static void DrawDebugBox(float width, float height, Vector3 center, Color color)
        {
            float widthDel = width / 2;
            float heightDel = height / 2;

            Vector3 leftTop = new Vector3(center.x - widthDel, center.y + heightDel, center.z);
            Vector3 rightTop = new Vector3(center.x + widthDel, center.y + heightDel, center.z);
            Vector3 leftBottom = new Vector3(center.x - widthDel, center.y - heightDel, center.z);
            Vector3 rightBottom = new Vector3(center.x + widthDel, center.y - heightDel, center.z); 

            Debug.DrawLine(leftTop, rightTop, color);
            Debug.DrawLine(rightTop, rightBottom, color);
            Debug.DrawLine(rightBottom, leftBottom, color);
            Debug.DrawLine(leftBottom, leftTop, color);
        }
   }
}
