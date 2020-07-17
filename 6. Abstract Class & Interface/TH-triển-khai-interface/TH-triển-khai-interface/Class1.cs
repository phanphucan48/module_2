﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TH_triển_khai_interface
{
   
    
    public class CircleComparator : IComparer<Circle>
        {
            public int Compare(Circle c1, Circle c2)
            {
                if (c1.getRadius() > c2.getRadius()) return 1;
                else if (c1.getRadius() < c2.getRadius()) return -1;
                else return 0;
            }
        }
    }


