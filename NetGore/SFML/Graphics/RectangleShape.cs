﻿using System;
using System.Runtime.InteropServices;
using System.Security;
using SFML.Window;
using Vector2f = SFML.Graphics.Vector2;

namespace SFML
{
    namespace Graphics
    {
        ////////////////////////////////////////////////////////////
        /// <summary>
        /// Specialized shape representing a rectangle
        /// </summary>
        ////////////////////////////////////////////////////////////
        public class RectangleShape : Shape
        {
            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Default constructor
            /// </summary>
            ////////////////////////////////////////////////////////////
            public RectangleShape() :
                this(new Vector2f(0, 0))
            {
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the shape with an initial size
            /// </summary>
            /// <param name="size">Size of the shape</param>
            ////////////////////////////////////////////////////////////
            public RectangleShape(Vector2f size)
            {
                Size = size;
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Construct the shape from another shape
            /// </summary>
            /// <param name="copy">Shape to copy</param>
            ////////////////////////////////////////////////////////////
            public RectangleShape(RectangleShape copy) :
                base(copy)
            {
                Size = copy.Size;
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// The size of the rectangle
            /// </summary>
            ////////////////////////////////////////////////////////////
            public Vector2f Size
            {
                get { return mySize; }
                set { mySize = value; Update(); }
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Get the total number of points of the shape
            /// </summary>
            /// <returns>The total point count</returns>
            ////////////////////////////////////////////////////////////
            public override uint GetPointCount()
            {
                return 4;
            }

            ////////////////////////////////////////////////////////////
            /// <summary>
            /// Get a point of the shape.
            ///
            /// The result is undefined if index is out of the valid range.
            /// </summary>
            /// <param name="index">Index of the point to get, in range [0 .. PointCount - 1]</param>
            /// <returns>Index-th point of the shape</returns>
            ////////////////////////////////////////////////////////////
            public override Vector2f GetPoint(uint index)
            {
                switch (index)
                {
                    default:
                    case 0: return new Vector2f(0, 0);
                    case 1: return new Vector2f(mySize.X, 0);
                    case 2: return new Vector2f(mySize.X, mySize.Y);
                    case 3: return new Vector2f(0, mySize.Y);
                }
            }

            private Vector2f mySize;
        }
    }
}
