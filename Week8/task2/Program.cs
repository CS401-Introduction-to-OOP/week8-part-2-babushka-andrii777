using Ass83;

Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;
p2.Y = 12;

p2.Print();
p1.Print();

PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;
r2.X = 22;

r2.Print();
r1.Print();

BoxingTester.Test();