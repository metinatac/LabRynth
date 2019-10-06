using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinates 
{
    public int index =0;

        private static Coordinates instance = null;

        public List<Vector3> points = new List<Vector3>();
    

        private Coordinates()
        {
        }

        public static Coordinates Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Coordinates();
                }
                return instance;
            }
        }

    public bool isEmpty()
    {
        return points.Count == 0;
    }

}


