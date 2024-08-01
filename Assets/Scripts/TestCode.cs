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
            var values = CultureInfo.GetCultures(CultureTypes.AllCultures);

            string specificCultureStr = string.Empty;
            foreach (var value in values)
            {
                try
                {
                    CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(value.Name);
                    DebugLog.Print(cultureInfo.Name);
                }
                catch
                {
                    DebugLog.Print(" - ");
                }
            }
        }
    }
}
