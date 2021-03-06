using static System.Console;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class Program
    {
        public delegate void myDeligate();
        const double Pi = 3.141592653;
        const decimal E = 1.414213562373095048M;
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("\tHello! This program can help you execute a mathematical quest" +
                      "\n\tThis program contains the basic formulas where \u03c0 is used." +
                      $"\n\t\t\u03c0 = {Pi} \te = {E}");
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Enter \"help\" to see list of formulas" +
                      "\nIf you want to end your work enter <exit>.");
            ResetColor();
            string userEnter = ReadLine().ToLower();
            ForegroundColor = ConsoleColor.DarkMagenta;
            Dictionary<string, myDeligate> dic = new Dictionary<string, myDeligate>()
            {
                { "help", new myDeligate(Help) },
                { "1", new myDeligate(CircumferenceRadius)},
                { "2", new myDeligate(CircumferencePiDiameter) },
                { "3", new myDeligate(CircumferenceAreaOfCircle) },
                { "4", new myDeligate(CircumferencePiDiagonal) },
                { "5", new myDeligate(CircumferencePiSide) },
                { "6", new myDeligate(CircumferenceSidesAndArea) },
                { "7", new myDeligate(CircumferenceAreaAndHalfPerimeter) },
                { "8", new myDeligate(CircumferenceRegularPolygon) },
                { "9", new myDeligate(ArcLength) },
                { "10", new myDeligate(CircleAreaOfRadius) },
                { "11", new myDeligate(CircleAreaOfDiameter) },
                { "12", new myDeligate(CircleDiameterOfLenght) },
                { "13", new myDeligate(CircleRadiusOfArea) },
                { "14", new myDeligate(CircleRadiusOfLength) },
                { "15", new myDeligate(CircleRadiusOfAreaAndCentralAngle) },
                { "16", new myDeligate(SectorAreaOfRadiusAndAngle) },
                { "17", new myDeligate(RingAreaOfRadius) },
                { "18", new myDeligate(VolumeCylinderOfRadiusAndHeight) },
                { "19", new myDeligate(AreaOfRightCylinder) },
                { "20", new myDeligate(VolumeOfCircularCone) },
                { "21", new myDeligate(AreaOfRightCircularCone) },
                { "22", new myDeligate(VolumeSphere) },
                { "23", new myDeligate(AreaSphere) },
                { "24", new myDeligate(SurfaceAreaOfCircularOfRadiusAndGenaratrix) },
                { "exit", new myDeligate(Exit) },
            };
            if (dic.ContainsKey(userEnter))
            {
                dic[userEnter]();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You have entered incorrect data, please read:");
                ResetColor();
                Help();
            }
            void Help()
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("\t\tYou can use the following formulas:");
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine(
                    "\n1) Find the circumference of a circle using the radius;" +
                    "\n2) Find the circumference of a circle using the diameter;" +
                    "\n3) Find the circumference of a circle using the area of a circle;" +
                    "\n4) Find the circumference of a circle using the diagonal of an inscribed rectangle;" +
                    "\n5) Find the circumference of a circle using the side of the circumscribed square;" +
                    "\n6) Find the circumference of a circle using the sides and area of an inscribed triangle;" +
                    "\n7) Find the circumference of a circle using the area and semiperimeter of the circumscribed triangle;" +
                    "\n8) Find the circumference of a circle using the side of an inscribed regular polygon;" +
                    "\n9) Find the length of a circular arc using radius and central angle;" +
                    "\n10) Find the area of a circle using the radius;" +
                    "\n11) Find the area of a circle using the diameter;" +
                    "\n12) Find the diameter of a circle using the circumference of a circle;" +
                    "\n13) Find the radius of a circle using the area of a circle;" +
                    "\n14) Find the radius of a circle using the circumference of a circle;" +
                    "\n15) Find the radius of a circle using the area of the sector of the circle and the central angle;" +
                    "\n16) Find area of a sector using radius and angle;" +
                    "\n17) Find the area of a ring using the inner and outer radius;" +
                    "\n18) Find the volume of a circular cylinder using radius and height;" +
                    "\n19) Find the lateral surface area of a right circular cone using radius and height;" +
                    "\n20) Find the volume of a circular cone using radius and height;" +
                    "\n21) Find the lateral surface area of a right circular cone using the generatrix and the radius;" +
                    "\n22) Find the volume of a sphere using the radius;" +
                    "\n23) Find the surface area of a sphere (area of a sphere) using the radius;" +
                    "\n24) Find the surface area of a circular cone using generatrix and radius;");
                Main(args);
            }
            double Validation()
            {
                bool usEnterIsDouble;
                double receivedValue;
                string usEnter;
                do
                {
                    ResetColor();
                    usEnter = ReadLine().ToLower().Replace('.', ',');
                    usEnterIsDouble = Double.TryParse(usEnter, out receivedValue);
                    if (!usEnterIsDouble)
                    {
                        NotCorrect();
                    }
                }
                while (!usEnterIsDouble);
                receivedValue = double.Parse(usEnter);
                ForegroundColor = ConsoleColor.Green;
                return receivedValue;
            }
            void NotCorrect()
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("You have entered incorrect data! try again.");
                ResetColor();
            }
            void CircumferenceRadius()
            {
                WriteLine("Length circumference in using of radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                double length = 2.0 * Pi * radius;
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferencePiDiameter()
            {
                WriteLine("Circumference in terms of diameter:\n" +
                          "Please, enter diameter(D):");
                double diameter = Validation();
                double length = Pi * diameter;
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferenceAreaOfCircle()
            {
                WriteLine("Circumference in terms of the area of a circle:\n" +
                          "Please, enter area of a circle(S):");
                double areaOfCircle = Validation();
                double length = Math.Sqrt((areaOfCircle * 4 * Pi));
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferencePiDiagonal()
            {
                WriteLine("Circumference of a circle through the diagonal of an inscribed rectangle:\n" +
                          "Please, enter diagonal(D):");
                double diagonal = Validation();
                double length = Pi * diagonal;
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferencePiSide()
            {
                WriteLine("Circumference through the side of the circumscribed square:\n" +
                          "Please, enter side(a):");
                double diagonal = Validation();
                double side = Pi * diagonal;
                WriteLine($"Circumference is {Math.Abs(side)}");
                StartMenu();
            }
            void CircumferenceSidesAndArea()
            {
                WriteLine("Circumference in terms of sides and area of an inscribed triangle:\n" +
                          "Please, enter area of a triangle(S):");
                double areaOfTriangle = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter side A:");
                double sideA = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter side B:");
                double sideB = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter side C:");
                double sideC = Validation();
                double length = Pi * ((sideA * sideB * sideC) / (2 * areaOfTriangle));
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferenceAreaAndHalfPerimeter()
            {
                WriteLine("Circumference in terms of area and half-perimeter of an inscribed triangle:\n" +
                          "Please, enter half-perimeter(p):");
                double areaOfTriangle = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter area of an inscribed triangle:");
                double halfPerimeter = Validation();
                double length = (2 * Pi) * (areaOfTriangle / halfPerimeter);
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void CircumferenceRegularPolygon()
            {
                WriteLine("Circumference through the side of an inscribed regular polygon:\n" +
                          "Please, enter number of sides of a polygon(N):");
                double numberOfSides = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter side of the polygon:");
                double sideOfPolygon = Validation();
                double length = Pi * (sideOfPolygon / (Math.Sin(180 / numberOfSides)));
                WriteLine($"Circumference is {Math.Abs(length)}");
                StartMenu();
            }
            void ArcLength()
            {
                WriteLine("Arc length through angle and radius:\n" +
                          "Please, enter circle radius(r):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter central angle in degrees:");
                double centralAngle = Validation();
                double length = (Pi * radius * centralAngle) / 180;
                WriteLine($"Arc length is {Math.Abs(length)}");
                StartMenu();
            }
            void CircleAreaOfRadius()
            {
                WriteLine("Circle area in terms of radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                double area = Pi * Math.Pow(radius, 2);
                WriteLine($"Area of a circle is {Math.Abs(area)}");
                StartMenu();
            }
            void CircleAreaOfDiameter()
            {
                WriteLine("Circle area in terms of diameter:\n" +
                          "Please, enter diameter(D):");
                double diameter = Validation();
                double area = (Pi * Math.Pow(diameter, 2)) / 4;
                WriteLine($"Area of a circle is {Math.Abs(area)}");
                StartMenu();
            }
            void CircleDiameterOfLenght()
            {
                WriteLine("Circle diameter in terms of circumference:\n" +
                          "Please, enter circumference(L):");
                double circumference = Validation();
                double diameter = circumference / Pi;
                WriteLine($"Circle diameter is {Math.Abs(diameter)}");
                StartMenu();
            }
            void CircleRadiusOfArea()
            {
                WriteLine("Circle diameter in terms of circumference:\n" +
                          "Please, enter area(S):");
                double area = Validation();
                double radius = Math.Sqrt(area / Pi);
                WriteLine($"Circle radius is {Math.Abs(radius)}");
                StartMenu();
            }
            void CircleRadiusOfLength()
            {
                WriteLine("Circle radius through lenght:\n" +
                          "Please, enter lenght(P):");
                double lenght = Validation();
                double radius = lenght / (2 * Pi);
                WriteLine($"Circle radius is {Math.Abs(radius)}");
                StartMenu();
            }
            void CircleRadiusOfAreaAndCentralAngle()
            {
                WriteLine("The radius of the circle through the area of the sector and the central angle:\n" +
                          "Please, enter area of a sector of a circle(S):");
                double areaOfSector = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter central angle in degrees:");
                double centralAngle = Validation();
                double radius = Math.Sqrt((360 * areaOfSector) / (Pi * centralAngle));
                WriteLine($"Circle radius is {Math.Abs(radius)}");
                StartMenu();
            }
            void SectorAreaOfRadiusAndAngle()
            {
                WriteLine("The area of a sector of a circle in terms of the radius and angle of the sector:\n" +
                          "Please, enter area of a sector of a circle(S):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter sector angle in degrees:");
                double sectorAngle = Validation();
                double area = Pi * Math.Pow(radius, 2) * (sectorAngle / 360);
                WriteLine($"Sector area of a circle is {Math.Abs(area)}");
                StartMenu();
            }
            void RingAreaOfRadius()
            {
                WriteLine("Ring area in terms of inner and outer radius:\n" +
                          "Please, enter outer radius(R):");
                double outerRadius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter inner radius(r):");
                double innerRadius = Validation();
                double area = Pi * (Math.Pow(outerRadius, 2) - Math.Pow(innerRadius, 2));
                WriteLine($"Ring area is {Math.Abs(area)}");
                StartMenu();
            }
            void VolumeCylinderOfRadiusAndHeight()
            {
                WriteLine("Volume of a circular cylinder in terms of height and radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter height:");
                double height = Validation();
                double volume = Pi * height * Math.Pow(radius, 2);
                WriteLine($"Volume of a circular cylinder is {Math.Abs(volume)}");
                StartMenu();
            }
            void AreaOfRightCylinder()
            {
                WriteLine("Side surface area of a right circular cylinder in terms of radius and height:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter height:");
                double height = Validation();
                double area = 2 * Pi * radius * height;
                WriteLine($"Lateral surface area of a right circular cylinder is {Math.Abs(area)}");
                StartMenu();
            }
            void VolumeOfCircularCone()
            {
                WriteLine("Volume of a circular cone in terms of radius and height:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter height:");
                double height = Validation();
                double volume = (Pi * Math.Pow(radius, 2) * height) / 3;
                WriteLine($"Volume of a circular cone is {Math.Abs(volume)}");
                StartMenu();
            }
            void AreaOfRightCircularCone()
            {
                WriteLine("The area of the lateral surface of a right circular cone through the generatrix and the radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter a generatrix:");
                double generatrix = Validation();
                double area = Pi * radius * generatrix;
                WriteLine($"Lateral surface area of a right circular cone is {Math.Abs(area)}");
                StartMenu();
            }
            void VolumeSphere()
            {
                WriteLine("Volume of a sphere in terms of radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                double volume = (4 / 3) * Pi * Math.Pow(radius, 3);
                WriteLine($"Sphere volume is {Math.Abs(volume)}");
                StartMenu();
            }
            void AreaSphere()
            {
                WriteLine("Area of a sphere in terms of radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                double area = 4 * Pi * Math.Pow(radius, 2);
                WriteLine($"Sphere area is {Math.Abs(area)}");
                StartMenu();
            }
            void SurfaceAreaOfCircularOfRadiusAndGenaratrix()
            {
                WriteLine("Surface area of a circular cone through generatrix and radius:\n" +
                          "Please, enter radius(R):");
                double radius = Validation();
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine("Please, enter a generatrix:");
                double generatrix = Validation();
                double area = Pi * radius * (radius + generatrix);
                WriteLine($"Lateral surface area of a right circular cone is {Math.Abs(area)}");
                StartMenu();
            }
            void Exit()
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Goodbye!");
                ResetColor();
            }
            void StartMenu()
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("If you want to continue, please enter \"yes\" or \"y\":");
                ResetColor();
                string answer = ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                    Main(args);
                else
                    Exit();
            }
        }
    }
}
