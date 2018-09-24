using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfWorkplace.CustomControls.Wrappers
{
    public class DrawingCanvas: Canvas
    {
        private List<Visual> visuals = new List<Visual>();

        public DrawingCanvas()
        {

        }
        

        protected override int VisualChildrenCount => visuals.Count;
        protected override Visual GetVisualChild(int index)
        {
            return visuals[index];
        }

        public void AddVisual(Visual visual)
        {
            visuals.Add(visual);

            base.AddVisualChild(visual);
            base.AddLogicalChild(visual);
        }

        public void DeleteVisual(Visual visual)
        {
            visuals.Remove(visual);

            base.RemoveVisualChild(visual);
            base.RemoveLogicalChild(visual);
        }

        /// <summary>
        /// In this case, the code ignores any hit object that isn’t a DrawingVisual, 
        /// including the DrawingCanvas itself.
        /// If no squares are clicked, the method returns a null reference.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public DrawingVisual GetVisual(Point point)
        {
            HitTestResult hitResult = VisualTreeHelper.HitTest(this, point);
            return hitResult.VisualHit as DrawingVisual;
        }


         
    }
}
