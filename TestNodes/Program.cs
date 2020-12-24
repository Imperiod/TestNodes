using System;
using Algorithms;
using System.Collections.Generic;

namespace TestNodes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Node node = new Node(0, 0, new List<Node>() {
            //    new Node(1, 5, new List<Node>()
            //    {
            //        new Node(5, 5, new List<Node>()
            //        {
            //            new Node(7, 5),
            //            new Node(4, 1, new List<Node>()
            //            {
            //                new Node(6, 1, new List<Node>()
            //                {
            //                    new Node(7, 6)
            //                })
            //            })
            //        }),
            //        new Node(2, 1, new List<Node>()
            //        {
            //            new Node(4, 1, new List<Node>()
            //            {
            //                new Node(6, 1, new List<Node>()
            //                {
            //                    new Node(7, 1)
            //                })
            //            })
            //        })
            //    }),
            //    new Node(2, 1, new List<Node>()
            //    {
            //        new Node(1, 1, new List<Node>()
            //        {
            //            new Node(5, 5, new List<Node>()
            //            {
            //                new Node(7, 5),
            //                new Node(4, 1, new List<Node>()
            //                {
            //                    new Node(6, 1, new List<Node>()
            //                    {
            //                        new Node(7, 6)
            //                    })
            //                })
            //            })
            //        }),
            //        new Node(4, 1, new List<Node>()
            //        {
            //            new Node(5, 1, new List<Node>()
            //            {
            //                new Node(7, 5)
            //            }),
            //            new Node(6, 1, new List<Node>()
            //            {
            //                new Node(7, 6)
            //            })
            //        })
            //    }),
            //    new Node(3, 1, new List<Node>()
            //    {
            //        new Node(6, 1, new List<Node>()
            //        {
            //            new Node(4, 1, new List<Node>()
            //            {
            //                new Node(5, 1, new List<Node>()
            //                {
            //                    new Node(7, 5)
            //                })
            //            }),
            //            new Node(7, 6)
            //        })
            //    })
            //});

            #region Points
            List<NodePoint> nodePoints = new List<NodePoint>();

            //Start point 0
            NodePoint nodePoint = new NodePoint();
            nodePoint.Points.Add((0, 0));
            nodePoint.Points.Add((1, 10));
            nodePoint.Points.Add((2, 6));
            nodePoint.Points.Add((3, 8));
            nodePoint.Points.Add((4, -1));

            nodePoints.Add(nodePoint);

            //1
            nodePoint = new NodePoint();
            nodePoint.Points.Add((10, 26));
            nodePoint.Points.Add((5, 14));
            nodePoint.Points.Add((2, 5));

            nodePoints.Add(nodePoint);

            //2
            nodePoint = new NodePoint();
            nodePoint.Points.Add((5, 12));
            nodePoint.Points.Add((3, 8));

            nodePoints.Add(nodePoint);

            //3
            nodePoint = new NodePoint();
            nodePoint.Points.Add((5, 11));
            nodePoint.Points.Add((6, 8));
            nodePoint.Points.Add((7, 8));
            nodePoint.Points.Add((4, 8));

            nodePoints.Add(nodePoint);

            //4
            nodePoint = new NodePoint();
            nodePoint.Points.Add((3, 8));
            nodePoint.Points.Add((7, 10));
            nodePoint.Points.Add((9, 17));

            nodePoints.Add(nodePoint);

            //5
            nodePoint = new NodePoint();
            nodePoint.Points.Add((6, 7));
            nodePoint.Points.Add((8, 8));
            nodePoint.Points.Add((10, 20));

            nodePoints.Add(nodePoint);

            //6
            nodePoint = new NodePoint();
            nodePoint.Points.Add((5, 7));
            nodePoint.Points.Add((8, 8));
            nodePoint.Points.Add((7, 7));

            nodePoints.Add(nodePoint);

            //7
            nodePoint = new NodePoint();
            nodePoint.Points.Add((6, 7));
            nodePoint.Points.Add((8, 11));
            nodePoint.Points.Add((9, 13));

            nodePoints.Add(nodePoint);

            //8
            nodePoint = new NodePoint();
            nodePoint.Points.Add((5, 8));
            nodePoint.Points.Add((10, 18));
            nodePoint.Points.Add((9, 13));

            nodePoints.Add(nodePoint);

            //9
            nodePoint = new NodePoint();
            nodePoint.Points.Add((8, 13));
            nodePoint.Points.Add((10, 19));

            nodePoints.Add(nodePoint);

            //End point not enter
            #endregion

            Node node = new Node(nodePoints);

            //Node n = node.Rebuild(node.GetShortWayToNode(5, node));

            node = node.Rebuild(node.GetShortWayToNode(nodePoints.Count, node));


            //Console.WriteLine(n.ToString(n));

            Console.WriteLine(node.ToString(node));
            Console.ReadKey();
        }
    }
}
