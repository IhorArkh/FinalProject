using Catalog.Data.Entities;

namespace Catalog.Data;

public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (!context.Products.Any())
        {
            await context.Products.AddRangeAsync(GetPreconfiguredProducts());

            await context.SaveChangesAsync();
        }
    }

    private static IEnumerable<ProductEntity> GetPreconfiguredProducts()
    {
        return new List<ProductEntity>()
        {
            new ProductEntity()
            {
                Name = "Balmain B-Bold chunky sneakers",
                Description = "Balmain showcases its futuristic approach to design in these B-Bold sneakers. Set on a chunky sole, the pair features silver-tone metal details throughout.",
                Price = 705.00m,
                AvailableStock = 100,
                PictureFileName = "1.jpg",
                Type = "Male",
                Brand = "Balmain"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana NS1 low-top sneakers",
                Description = "Give your days a kick thanks to Dolce & Gabbana and these grey and off white NS1 sneakers. Now, you can do anything. Featuring contrasting panels, branded detailing to the sides, a logo patch at the tongue, a lace-up front fastening, a round toe, a flat rubber sole and a fabric mix.",
                Price = 575.00m,
                AvailableStock = 100,
                PictureFileName = "2.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana Portofino logo-detail sneakers",
                Description = "Need some good news? Masters of streetwear, Dolce & Gabbana have turned their well-trained eye in your direction and created these Portofino sneakers. Now the bad news, they're not yours....yet.",
                Price = 495.00m,
                AvailableStock = 100,
                PictureFileName = "3.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Nike x Tom Sachs General Purpose \"Dark Sulfur\" sneakers",
                Description = "Nike has collaborated with the American artist, Tom Sachs, for a new sneaker model. This pair is crafted from yellow suede, highlighted with a white Swoosh logo on the sides while, underneath, a faux-vintage cream midsole alongside a black outsole finishes the look. ",
                Price = 139.99m,
                AvailableStock = 100,
                PictureFileName = "4.jpg",
                Type = "Female",
                Brand = "Nike"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana Portofino low-top sneakers",
                Description = "Portofino should be on your list, whether it's your shopping list or destination bucket list. If you don't have time to visit Portofino, consider wearing these white and pink calf leather Portofino low-top sneakers from Dolce & Gabbana as the next best option. If you can do both, we recommend that. Featuring a round toe, a lace-up front fastening, a logo patch at the tongue, a flat rubber sole and logo lettering at the heel.",
                Price = 495.00m,
                AvailableStock = 100,
                PictureFileName = "5.jpg",
                Type = "Female",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana logo-print low-top sneakers",
                Description = "Dolce & Gabbana showcase a sporty appeal with these low-top sneakers. The colour-block design and sleek silhouette boast a knitted upper which features the brand’s signature logo print spread across both shoes for an unmistakable branded finish..",
                Price = 549.99m,
                AvailableStock = 100,
                PictureFileName = "6.jpg",
                Type = "Female",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Nike Air Max 1 Premium \"Dirty Denim\" sneakers",
                Description = "Nike's Air Max 1 PRM \"Dirty Denim\" is built with an upper that blends washed denim and aged worn-out suede, while underneath, a pre-yellow midsole adds a vintage look. The usual Swoosh logo stands out on the sides in a royal blue tone.",
                Price = 154.99m,
                AvailableStock = 100,
                PictureFileName = "7.jpg",
                Type = "Female",
                Brand = "Nike"
            },
            new ProductEntity()
            {
                Name = "Alexander McQueen perforated low-top sneakers",
                Description = "Perforated low-top sneakers from Alexander McQueen featuring white, calf leather, fully perforated, front lace-up fastening, logo-print tongue, round toe, branded heel counter, branded insole and chunky rubber sole.",
                Price = 549.99m,
                AvailableStock = 100,
                PictureFileName = "8.jpg",
                Type = "Female",
                Brand = "Alexander McQueen"
            },
            new ProductEntity()
            {
                Name = "Alexander McQueen Deck Plimsoll high-top sneakers",
                Description = "Sarah Burton's penchant for theatrical proportions is on full show with these Deck Plimsoll high-top sneakers by Alexander McQueen. Crafted in Italy from black canvas, they feature a logo stamp at the tongue, front lace-up fastening and are set on a chunky rubber sole.",
                Price = 419.99m,
                AvailableStock = 100,
                PictureFileName = "9.jpg",
                Type = "Female",
                Brand = "Alexander McQueen"
            },
            new ProductEntity()
            {
                Name = "Alexander McQueen Sprint Runner low-top sneakers",
                Description = "Sprint Runner low-top sneakers from Alexander McQueen featuring multicolour, leather, logo-print tongue, logo patch to the side, round toe, front lace-up fastening and chunky rubber sole.",
                Price = 595.00m,
                AvailableStock = 100,
                PictureFileName = "10.jpg",
                Type = "Female",
                Brand = "Alexander McQueen"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana Daymaster leather sneaker",
                Description = "Daymaster leather sneaker from DOLCE & GABBANA featuring black, leather, chunky rubber sole, front lace-up fastening, embossed logo to the side, embossed logo to the rear, logo patch at the tongue, pull-tab at the heel, almond toe and branded insole.",
                Price = 649.99m,
                AvailableStock = 100,
                PictureFileName = "11.jpg",
                Type = "Female",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana",
                Description = "It's all in the footwear: a fact that these Dolce & Gabbana panelled sneakers are more than aware of. That's why they've ensured that they're looking their very best just for you.",
                Price = 675.00m,
                AvailableStock = 100,
                PictureFileName = "12.jpg",
                Type = "Female",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Balmain B-East low-top sneakers",
                Description = "White calf leather panelled design mesh detailing logo-debossed tongue branded heel counter round toe front lace-up fastening chunky rubber sole",
                Price = 497.00m,
                AvailableStock = 100,
                PictureFileName = "13.jpg",
                Type = "Male",
                Brand = "Balmain"
            },
            new ProductEntity()
            {
                Name = "Balmain B-Bold slip-on sneakers",
                Description = "Balmain's bold spirit is inherited by these slip-on sneakers. Made from a stretch sock style for comfort, a polished gold-tone B for Balmain finishes the pair with recognisable branding.",
                Price = 479.99m,
                AvailableStock = 100,
                PictureFileName = "14.jpg",
                Type = "Male",
                Brand = "Balmain"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana Airmaster embroidered-logo sneakers",
                Description = "Dolce & Gabbana pairs the brand's signature sophisticated style with streetwear influences in this pair of sneakers. Featuring the distinctive DG logo embroidered at the sidewalls alongside a multi-panel construction, the shoes have a creative and modern feel.",
                Price = 649.99m,
                AvailableStock = 100,
                PictureFileName = "15.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana lace-up low-top sneakers",
                Description = "These sneakers from Dolce & Gabbana boast an intriguing silhouette, thanks to oversized laces and an exaggerated tongue, contrasted with silver-tone detailing throughout that gives this pair a futuristic feel.",
                Price = 749.99m,
                AvailableStock = 100,
                PictureFileName = "16.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana Airmaster panelled low-top sneakers",
                Description = "Military green/multicolour calf leather Airmaster panelled low-top sneakers from DOLCE & GABBANA featuring colour-block design, round toe, front lace-up fastening, logo patch at the tongue, branded insole, branded heel counter and chunky rubber sole.",
                Price = 675.00m,
                AvailableStock = 100,
                PictureFileName = "17.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            },
            new ProductEntity()
            {
                Name = "Dolce & Gabbana lace-up low-top sneakers",
                Description = "These low-top sneakers from Dolce & Gabbana boast a panelled design and are made instantly recognisable by the inclusion of a logo patch to the tongue and embossed logo lettering to the heel counter.",
                Price = 649.97m,
                AvailableStock = 100,
                PictureFileName = "18.jpg",
                Type = "Male",
                Brand = "Dolce & Gabbana"
            }
        };
    }
}