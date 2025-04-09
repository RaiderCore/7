using System;
using System.Windows;
using System.Windows.Controls;

namespace TaskSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TaskComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputPanel.Children.Clear();
            ResultTextBlock.Text = "";

            switch (TaskComboBox.SelectedIndex)
            {
                case 0: AddInputFields("Number 1", "Number 2"); break;
                case 1: AddInputFields("Salary", "Experience (years)"); break;
                case 2: AddInputFields("Point A (x0)", "Point A (y0)", "Point B (x1)", "Point B (y1)"); break;
                case 3: AddInputFields("Side a", "Side b", "Side c"); break;
                case 4: AddInputFields("Number 1", "Number 2", "Number 3"); break;
                case 5: AddInputFields("Point A (x)", "Point A (y)"); break;
                case 6: AddInputFields("Point A (x)", "Point A (y)", "Radius R"); break;
                case 7: AddInputFields("Triangle 1 (a1)", "Triangle 1 (b1)", "Triangle 1 (c1)", "Triangle 2 (a2)", "Triangle 2 (b2)", "Triangle 2 (c2)"); break;
                case 8: AddInputFields("Square Side (a)", "Circle Radius (R)"); break;
                case 9: AddInputFields("Number 1", "Number 2", "Number 3"); break;
                case 10: AddInputFields("Number"); break;
                case 11: AddInputFields("Point A (x)", "Point A (y)"); break;
                case 12: AddInputFields("Deposit Amount", "Term (months)"); break;
                case 13: AddInputFields("Number 1", "Number 2"); break;
                case 14: AddInputFields("Point A (x0)", "Point A (y0)", "Point B (x1)", "Point B (y1)"); break;
                case 15: AddInputFields("Point A (x)", "Point A (y)", "Inner Radius (r)", "Outer Radius (R)"); break;
                case 16: AddInputFields("Point A (x)", "Point A (y)"); break;
                case 17: AddInputFields("Side a", "Side b", "Side c"); break;
                case 18: AddInputFields("Number a", "Number b", "Number c"); break;
                case 19: AddInputFields("Flow Rate 1 (l/s)", "Flow Rate 2 (m^3/min)"); break;
                case 20: AddInputFields("Circle Area", "Square Area"); break;
                case 21: AddInputFields("Mass 1", "Volume 1", "Mass 2", "Volume 2"); break;
                case 22: AddInputFields("Speed 1 (km/h)", "Speed 2 (m/s)"); break;
                case 23: AddInputFields("Triangle Side (a)", "Circle Radius (r)"); break;
                case 24: AddInputFields("Resistance 1", "Voltage 1", "Resistance 2", "Voltage 2"); break;
                case 25: AddInputFields("Mass Venus", "Radius Venus", "Mass Saturn", "Radius Saturn"); break;
                case 26: AddInputFields("Current Time (24h)"); break;
                case 27: AddInputFields("Longitude", "Latitude"); break;
                case 28: AddInputFields("Distance Sirius (km)", "Distance Arcturus (parsecs)"); break;
                case 29: AddInputFields("Number"); break;
            }
        }

        private void AddInputFields(params string[] labels)
        {
            foreach (var label in labels)
            {
                InputPanel.Children.Add(new TextBlock { Text = label });
                InputPanel.Children.Add(new TextBox { Name = label.Replace(" ", "") });
            }
            Button solveButton = new Button { Content = "Solve" };
            solveButton.Click += SolveButton_Click;
            InputPanel.Children.Add(solveButton);
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (TaskComboBox.SelectedIndex)
                {
                    case 0: SolveTask1(); break;
                    case 1: SolveTask2(); break;
                    case 2: SolveTask3(); break;
                    case 3: SolveTask4(); break;
                    case 4: SolveTask5(); break;
                    case 5: SolveTask6(); break;
                    case 6: SolveTask7(); break;
                    case 7: SolveTask8(); break;
                    case 8: SolveTask9(); break;
                    case 9: SolveTask10(); break;
                    case 10: SolveTask11(); break;
                    case 11: SolveTask12(); break;
                    case 12: SolveTask13(); break;
                    case 13: SolveTask14(); break;
                    case 14: SolveTask15(); break;
                    case 15: SolveTask16(); break;
                    case 16: SolveTask17(); break;
                    case 17: SolveTask18(); break;
                    case 18: SolveTask19(); break;
                    case 19: SolveTask20(); break;
                    case 20: SolveTask21(); break;
                    case 21: SolveTask22(); break;
                    case 22: SolveTask23(); break;
                    case 23: SolveTask24(); break;
                    case 24: SolveTask25(); break;
                    case 25: SolveTask26(); break;
                    case 26: SolveTask27(); break;
                    case 27: SolveTask28(); break;
                    case 28: SolveTask29(); break;
                    case 29: SolveTask30(); break;
                }
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = "Error: " + ex.Message;
            }
        }

        // Реализация всех задач
        private void SolveTask1()
        {
            double num1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double num2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double sumOfSquares = num1 * num1 + num2 * num2;
            double squareOfSum = Math.Pow(num1 + num2, 2);
            ResultTextBlock.Text = sumOfSquares > squareOfSum ? "Sum of squares is greater" : "Square of sum is greater";
        }

        private void SolveTask2()
        {
            double salary = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            int experience = int.Parse(((TextBox)InputPanel.Children[3]).Text);
            double bonus = 0;
            if (experience >= 2 && experience < 5) bonus = 0.02;
            else if (experience >= 5 && experience < 10) bonus = 0.05;
            double total = salary + salary * bonus;
            ResultTextBlock.Text = $"Bonus: {bonus * 100}%, Total: {total}";
        }

        private void SolveTask3()
        {
            double x0 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y0 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double x1 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double y1 = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            ResultTextBlock.Text = distanceA > distanceB ? "Point A is farther" : "Point B is farther";
        }

        private void SolveTask4()
        {
            double a = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double b = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double c = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            bool isRight = (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
            ResultTextBlock.Text = isRight ? "The triangle is right-angled" : "The triangle is not right-angled";
        }

        private void SolveTask5()
        {
            double num1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double num2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double num3 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            num1 = num1 > 0 ? num1 * num1 : num1;
            num2 = num2 > 0 ? num2 * num2 : num2;
            num3 = num3 > 0 ? num3 * num3 : num3;
            ResultTextBlock.Text = $"Numbers: {num1}, {num2}, {num3}";
        }

        private void SolveTask6()
        {
            double x = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            string quadrant;
            if (x > 0 && y > 0) quadrant = "First Quadrant";
            else if (x < 0 && y > 0) quadrant = "Second Quadrant";
            else if (x < 0 && y < 0) quadrant = "Third Quadrant";
            else quadrant = "Fourth Quadrant";
            ResultTextBlock.Text = $"The point is in the {quadrant}";
        }

        private void SolveTask7()
        {
            double x = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double r = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double distance = Math.Sqrt(x * x + y * y);
            ResultTextBlock.Text = distance <= r ? "The point is inside the circle" : "The point is outside the circle";
        }

        private void SolveTask8()
        {
            double a1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double b1 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double c1 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double a2 = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double b2 = double.Parse(((TextBox)InputPanel.Children[9]).Text);
            double c2 = double.Parse(((TextBox)InputPanel.Children[11]).Text);
            double p1 = (a1 + b1 + c1) / 2;
            double area1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            double p2 = (a2 + b2 + c2) / 2;
            double area2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            ResultTextBlock.Text = area1 > area2 ? "Triangle 1 has a larger area" : "Triangle 2 has a larger area";
        }

        private void SolveTask9()
        {
            double a = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double r = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double squareArea = a * a;
            double circleArea = Math.PI * r * r;
            ResultTextBlock.Text = squareArea > circleArea ? "Square has a larger area" : "Circle has a larger area";
        }

        private void SolveTask10()
        {
            double num1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double num2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double num3 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            num1 = num1 > 0 ? Math.Pow(num1, 3) : 0;
            num2 = num2 > 0 ? Math.Pow(num2, 3) : 0;
            num3 = num3 > 0 ? Math.Pow(num3, 3) : 0;
            ResultTextBlock.Text = $"Numbers: {num1}, {num2}, {num3}";
        }

        private void SolveTask11()
        {
            int number = int.Parse(((TextBox)InputPanel.Children[1]).Text);
            bool isEven = number % 2 == 0;
            bool endsWith3 = number % 10 == 3;
            ResultTextBlock.Text = isEven ? "The number is even" : endsWith3 ? "The number ends with 3" : "The number is odd and does not end with 3";
        }

        private void SolveTask12()
        {
            double x = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            bool isFirstQuadrant = x > 0 && y > 0;
            ResultTextBlock.Text = isFirstQuadrant ? "The point is in the first quadrant" : "The point is not in the first quadrant";
        }

        private void SolveTask13()
        {
            double deposit = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            int term = int.Parse(((TextBox)InputPanel.Children[3]).Text);
            double rate = term <= 6 ? 0.06 : 0.08;
            double interest = deposit * rate * term / 12;
            ResultTextBlock.Text = $"Monthly interest: {interest}";
        }

        private void SolveTask14()
        {
            double num1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double num2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double diffOfSquares = num1 * num1 - num2 * num2;
            double squareOfDiff = Math.Pow(num1 - num2, 2);
            ResultTextBlock.Text = diffOfSquares > squareOfDiff ? "Difference of squares is greater" : "Square of difference is greater";
        }

        private void SolveTask15()
        {
            double x0 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y0 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double x1 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double y1 = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
            double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);
            ResultTextBlock.Text = distanceA < distanceB ? "Point A is closer" : "Point B is closer";
        }

        private void SolveTask16()
        {
            double x = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double r = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double R = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double distance = Math.Sqrt(x * x + y * y);
            ResultTextBlock.Text = distance >= r && distance <= R ? "The point is inside the torus" : "The point is outside the torus";
        }

        private void SolveTask17()
        {
            double x = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double y = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            bool isFourthQuadrant = x > 0 && y < 0;
            ResultTextBlock.Text = isFourthQuadrant ? "The point is in the fourth quadrant" : "The point is not in the fourth quadrant";
        }

        private void SolveTask18()
        {
            double a = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double b = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double c = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            bool isIsosceles = a == b || a == c || b == c;
            ResultTextBlock.Text = isIsosceles ? "The triangle is isosceles" : "The triangle is not isosceles";
        }

        private void SolveTask19()
        {
            double a = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double b = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double c = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            bool isPythagorean = (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
            ResultTextBlock.Text = isPythagorean ? "The numbers form a Pythagorean triple" : "The numbers do not form a Pythagorean triple";
        }

        private void SolveTask20()
        {
            double flow1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double flow2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            ResultTextBlock.Text = flow1 > flow2 ? "Flow rate 1 is greater" : "Flow rate 2 is greater";
        }

        private void SolveTask21()
        {
            double circleArea = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double squareArea = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            bool circleFits = Math.Sqrt(circleArea / Math.PI) * 2 <= Math.Sqrt(squareArea);
            bool squareFits = Math.Sqrt(squareArea) <= Math.Sqrt(circleArea / Math.PI) * 2;
            ResultTextBlock.Text = $"Circle fits in square: {circleFits}, Square fits in circle: {squareFits}";
        }

        private void SolveTask22()
        {
            double mass1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double volume1 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double mass2 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double volume2 = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;
            ResultTextBlock.Text = density1 > density2 ? "Material 1 has a higher density" : "Material 2 has a higher density";
        }

        private void SolveTask23()
        {
            double speed1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double speed2 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            speed2 *= 3.6; // Convert m/s to km/h
            ResultTextBlock.Text = speed1 > speed2 ? "Speed 1 is greater" : "Speed 2 is greater";
        }

        private void SolveTask24()
        {
            double a = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double r = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            bool circleFits = r <= a * Math.Sqrt(3) / 6;
            bool triangleFits = a <= r * 2 / Math.Sqrt(3);
            ResultTextBlock.Text = $"Circle fits in triangle: {circleFits}, Triangle fits in circle: {triangleFits}";
        }

        private void SolveTask25()
        {
            double resistance1 = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double voltage1 = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double resistance2 = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double voltage2 = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;
            ResultTextBlock.Text = current1 < current2 ? "Current 1 is smaller" : "Current 2 is smaller";
        }

        private void SolveTask26()
        {
            double massVenus = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double radiusVenus = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            double massSaturn = double.Parse(((TextBox)InputPanel.Children[5]).Text);
            double radiusSaturn = double.Parse(((TextBox)InputPanel.Children[7]).Text);
            double gVenus = 6.7e-8 * massVenus / (radiusVenus * radiusVenus);
            double gSaturn = 6.7e-8 * massSaturn / (radiusSaturn * radiusSaturn);
            ResultTextBlock.Text = gVenus > gSaturn ? "Venus has a higher gravitational acceleration" : "Saturn has a higher gravitational acceleration";
        }

        private void SolveTask27()
        {
            int time = int.Parse(((TextBox)InputPanel.Children[1]).Text);
            string timeOfDay = time < 12 ? "AM" : "PM";
            ResultTextBlock.Text = $"Time of day: {timeOfDay}";
        }

        private void SolveTask28()
        {
            double longitude = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double latitude = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            string hemisphere = longitude >= 0 ? "Eastern Hemisphere" : "Western Hemisphere";
            ResultTextBlock.Text = $"The location is in the {hemisphere}";
        }

        private void SolveTask29()
        {
            double distanceSirius = double.Parse(((TextBox)InputPanel.Children[1]).Text);
            double distanceArcturus = double.Parse(((TextBox)InputPanel.Children[3]).Text);
            distanceArcturus *= 3.086e13; // Convert parsecs to km
            ResultTextBlock.Text = distanceSirius > distanceArcturus ? "Sirius is farther" : "Arcturus is farther";
        }

        private void SolveTask30()
        {
            int number = int.Parse(((TextBox)InputPanel.Children[1]).Text);
            bool isEven = number % 2 == 0;
            bool endsWith7 = number % 10 == 7;
            

        }
    }
}

