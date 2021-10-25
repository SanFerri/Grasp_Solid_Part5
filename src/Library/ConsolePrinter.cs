using System;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    ///     ConsolePrinter ya no depende de Recipe si no que de IRecipeContent.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}