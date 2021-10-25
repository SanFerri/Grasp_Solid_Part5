using System.IO;

namespace Full_GRASP_And_SOLID
{
    // FilePrinter ya no depende de Recipe sino que de IRecipeContent.
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}