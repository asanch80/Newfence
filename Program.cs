/*Objective
• Define the problem by constructing an algorithm using pseudocode, and use that to write the application that calculates the total cost of a fence.
How much should a fence cost?

You've just been hired by Alton's Hardware Store.Your job is to develop a tool which will allow his customers to calculate the cost for installing a fence.Start by determining the algorithm to calculate the cost of installing the fence.
Create a program that will calculate the cost with tax of fencing a rectangular yard.The cost of the fencing will depend on the amount of fencing required(the perimeter of the yard), and the type of fencing used.Gates can are available for an additional cost.At least one gate is required.
Prices(including installation)

• Wooden fencing costs $25 per foot
• Chain - link fencing costs $15 per foot
• Gates cost $150 each.You must install at least one gate and can install up to 3
• A building permit is required.It costs $50.00.
• The tax rate is 6.0 % but it doesn't apply to the building permit

Your algorithm should allow any other person to achieve the same result by following your steps.They should not have to think about what they are doing.*/

internal class Program
{
    private static void Main()
    {
        //Welcome Banner--------------------------------------------------------------------------------------------
        Console.WriteLine("------------------------Welcome to Alton's Hardware Store------------------------");
        Console.WriteLine();
        Console.WriteLine("Please complete the following questions in order for us to give you a quote!!!");
        Console.WriteLine();
        //----------------------------------------------------------------------------------------------------------

        //Dictionary <string, int> materials = new ();

        //materials.Add("Wodden Fencing", 25);
        //materials.Add("chainLink", 15);
        //materials.Add ("gates", 150);
        //materials.Add("extra Gates", 150);
        //materials.Add("building Permit", 50);


        int woodenFencing = 25;
        int chainLink = 15;
        int gates = 150;
        int extraGates = 150;
        int buildingPermint = 50;//building permit is required, but not Taxable.

        //The tax rate is 6.0 % but it doesn't apply to the building permit
        double taxRate = 0.06;

        //-------------------Questions-----------------------------------------------------------------------------

        Console.WriteLine("How many foot of wooden fencing do you need? ");
        int wFencing = Convert.ToInt32(Console.ReadLine());
        int wf = woodenFencing * wFencing;
        Console.WriteLine("How many fencing links do you need? ");
        int cLink = Convert.ToInt32(Console.ReadLine());
        int cl = chainLink * cLink;
        Console.WriteLine("Do you need any extra gate? ");
        int eGates = Convert.ToInt32(Console.ReadLine());
        int eg = extraGates * eGates;

        //---------------------------Receipt-----------------------------------------------------------------------
        int receipt = gates + wf + cl + eg;
        double tax = receipt * taxRate;
        double total = tax + buildingPermint + receipt;
        Console.WriteLine();
        Console.WriteLine("-----------------------------------Quote-----------------------------------");
        Console.WriteLine();
        Console.WriteLine("Wooden Fencing total $ " + wf);
        Console.WriteLine("Chain Link total $ " + cl);
        Console.WriteLine("First gate $ " + gates);
        Console.WriteLine("Extra Gates total $ " + eg);
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Subtotal: " + receipt);
        Console.WriteLine("Tax: " + tax);
        Console.WriteLine("Building Permit - Not Taxable! $ " + buildingPermint);
        Console.WriteLine("Total: " + total);
    }
    

}
