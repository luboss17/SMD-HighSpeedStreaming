using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TestFormula
    {
        List<float> targetsList = new List<float>();
        private int maxPoint = 0;

        public TestFormula(int maxPoint)
        {
            this.maxPoint = maxPoint;
            set_targetList(this.maxPoint);
        }

        private void set_targetList(int maxPoint)
        {
            targetsList.Clear();
            switch (maxPoint)
            {
                case 1:
                    targetsList.Add(100);
                    break;
                case 2:
                    targetsList.Add(50);
                    targetsList.Add(100);
                    break;
                case 3:
                    targetsList.Add(20);
                    targetsList.Add(60);
                    targetsList.Add(100);
                    break;
                case 5:
                    targetsList.Add(20);
                    targetsList.Add(40);
                    targetsList.Add(60);
                    targetsList.Add(80);
                    targetsList.Add(100);
                    break;
                case 6:
                    targetsList.Add(10);
                    targetsList.Add(20);
                    targetsList.Add(40);
                    targetsList.Add(60);
                    targetsList.Add(80);
                    targetsList.Add(100);
                    break;
                case 7:
                    targetsList.Add(5);
                    targetsList.Add(10);
                    targetsList.Add(20);
                    targetsList.Add(40);
                    targetsList.Add(60);
                    targetsList.Add(80);
                    targetsList.Add(100);
                    break;
                case 10:
                    targetsList.Add(10);
                    targetsList.Add(20);
                    targetsList.Add(30);
                    targetsList.Add(40);
                    targetsList.Add(50);
                    targetsList.Add(60);
                    targetsList.Add(70);
                    targetsList.Add(80);
                    targetsList.Add(90);
                    targetsList.Add(100);
                    break;
                case 11:
                    targetsList.Add(5);
                    targetsList.Add(10);
                    targetsList.Add(20);
                    targetsList.Add(30);
                    targetsList.Add(40);
                    targetsList.Add(50);
                    targetsList.Add(60);
                    targetsList.Add(70);
                    targetsList.Add(80);
                    targetsList.Add(90);
                    targetsList.Add(100);
                    break;
                case 20:
                    targetsList.Add(5);
                    targetsList.Add(10);
                    targetsList.Add(15);
                    targetsList.Add(20);
                    targetsList.Add(25);
                    targetsList.Add(30);
                    targetsList.Add(35);
                    targetsList.Add(40);
                    targetsList.Add(45);
                    targetsList.Add(50);
                    targetsList.Add(55);
                    targetsList.Add(60);
                    targetsList.Add(65);
                    targetsList.Add(70);
                    targetsList.Add(75);
                    targetsList.Add(80);
                    targetsList.Add(85);
                    targetsList.Add(90);
                    targetsList.Add(95);
                    targetsList.Add(100);
                    break;
            }
        }

        public List<float> get_targetList()
        {
            return targetsList;
        }
    }
}
