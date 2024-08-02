using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

namespace KRN.Utility
{
    public class TestCode : MonoBehaviour
    {
        void Start()
        {
            DebugLog.Print(Utility.GetConvertDate(System.DateTime.Now, "yy/mm/dd"));
        }
    }
}
