using System.Text;

namespace MyBlazorApp.Models
{
    public class MaterialRepository
    {
        public static List<MaterialItem> BuildMaterialList()
        {
            List<MaterialItem> materials = new List<MaterialItem>()
            {
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem(),
                new MaterialItem()
            };
            return materials;
        }

        public static void AddMaterial(ref List<MaterialItem> materials)
        {
            materials.Add(new MaterialItem());
        }

        public static List<MaterialItem> GetItemsByCategory(string category, ref List<MaterialItem> materials)
        {
            return materials.Where(m=> m.Category == category).ToList();
        }
    }
}
