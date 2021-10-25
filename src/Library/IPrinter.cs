
namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Los printers ya no dependen de Recipe asi que tambien debemos de hacer que la interfaz no dependa de ellos.
    /// </summary>
    public interface IPrinter
    {
         void PrintRecipe(IRecipeContent recipeContent);
    }
}