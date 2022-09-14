using eLaptops.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLaptops.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Company
                if (!context.Company.Any())
                {
                    context.Company.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            CompanyName = "Lenovo",
                            CompanyLogo = "https://techtoday.lenovo.com/origind8/themes/custom/lenovod8/lenovo-logo-red.png",
                            Description = "Lenovo Group Limited, often shortened to Lenovo, is a Chinese multinational technology company specializing in designing, manufacturing, and marketing consumer electronics, personal computers, software, business solutions, and related services."
                        },
                        new Company()
                        {
                            CompanyName = "Acer",
                            CompanyLogo = "https://pbs.twimg.com/profile_images/915251508760920065/CS3k9D2W_400x400.jpg",
                            Description = "Acer Inc. is a Taiwanese multinational hardware and electronics corporation specializing in advanced electronics technology. Acer is the world's 6th-largest PC vendor by unit sales as of January 2021."
                        },
                        new Company()
                        {
                            CompanyName = "Dell",
                            CompanyLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Dell_logo_2016.svg/1200px-Dell_logo_2016.svg.png",
                            Description = "Dell is an American technology company that develops, sells, repairs, and supports computers and related products and services and is owned by its parent company, Dell Technologies."
                        },
                        new Company()
                        {
                            CompanyName = "Asus",
                            CompanyLogo = "https://i.pinimg.com/originals/e1/cf/78/e1cf785a803f64a2e1de84d1addacbc6.jpg",
                            Description = "Established in 1989, ASUS is a multinational company known for the world's best motherboards and high-quality personal computers, monitors, graphics cards, routers and other technology solutions."
                        },
                        new Company()
                        {
                            CompanyName = "Hp",
                            CompanyLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/HP_logo_2012.svg/2048px-HP_logo_2012.svg.png",
                            Description = "HP Inc. is an American multinational information technology company headquartered in Palo Alto, California, that develops personal computers, printers and related supplies, as well as 3D printing solutions."
                        },
                        new Company()
                        {
                            CompanyName = "Apple",
                            CompanyLogo = "https://www.apple.com/ac/structured-data/images/knowledge_graph_logo.png?202208222229",
                            Description = "Apple Inc. is an American multinational technology company that specializes in consumer electronics, software and online services headquartered in Cupertino, California, United States."
                        }
                    });
                    context.SaveChanges();
                }

                //Features
                if (!context.Features.Any())
                {
                    context.Features.AddRange(new List<Features>()
                    {
                        new Features()
                        {
                            FeatureName = "Stay Secure",
                            Description = "The Trusted Platform Module 2.0* is a commercial-grade security chip installed on the motherboard that creates and stores passwords and encryption keys. Meanwhile, the optional fingerprint reader with Windows Hello allows you to easily and securely log in with just one touch.",
                            FeaturePictureURL = "https://i.dell.com/is/image/DellContent/content/dam/ss2/product-images/dell-client-products/notebooks/vostro-notebooks/vostro-14-3420/media-gallery/black/notebook-vostro-14-3420-gallery-2.psd?fmt=png-alpha&pscan=auto&scl=1&hei=402&wid=528&qlt=100,0&resMode=sharp2&size=528,402"

                        },
                        new Features()
                        {
                            FeatureName = "Keep business moving",
                            Description = "Everyday tasks are quickly handled with ease using 12th Gen Intel® Core™ Processors. Plus, SSD storage delivers fast and smooth performance. And with up to an 80% charge in one hour using Express Charge*, you know you can rely on your device to power through the day.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/I/61aZQotsAeL._SX679_.jpg"

                        },
                        new Features()
                        {
                            FeatureName = "Perform at your best",
                            Description = "With 12th Gen Intel® Core™ processors, the IdeaPad 3i Gen 7 laptop lets you perform, and study at your best. There's also plenty of space for all your digital files, including a dual solid-state and hard-disk drive option, combining storage and speed. And don't worry about your desk getting cluttered thanks to the full function USB-C port for faster data transfer, power delivery, and 4K display connectivity.",
                            FeaturePictureURL = "https://www.lenovo.com/medias/?context=bWFzdGVyfHJvb3R8MTAwNjgzfGltYWdlL3BuZ3xoODEvaDk2LzE0NzMwMTY2MzcwMzM0LmpwZ3w0ZTQ4YjJiNDA3YWRhOGY5OGJhMzQzMjcxYzA5NTExZDc5ZWIxY2E0ODU1NDRiMTVjMTNkMGNmM2Y3YjM5ZWJm&w=1920"
                        },
                        new Features()
                        {
                            FeatureName = "Crystal-clear collaboration",
                            Description = "Say goodbye to poor quality videocalls. The IdeaPad 3i Gen 7 laptop has dual-array microphones to ensure everyone can be heard loud and clear, while Dolby Audio™ speakers deliver awesome sound. Smart noise-cancelling technology eliminates annoying background noise, so your online classes and get-togethers are silky smooth. Plus, you can turn the 720p HD camera off and on via the webcam privacy shutter.",
                            FeaturePictureURL = "https://www.lenovo.com/medias/?context=bWFzdGVyfHJvb3R8MjAzODM1fGltYWdlL3BuZ3xoZjEvaDA5LzE0NzMwMTY2NDM1ODcwLmpwZ3xjZWE4OWFiMjY1MThkZmM0ODVjOTkwMzI2NWE4NGQyOGJmNTBiYjU5MTM1OGZjNWUyZDg2YTkyODNhMjZjNWY1&w=1920"
                        },
                        new Features()
                        {
                            FeatureName = "Made to travel",
                            Description = "Exceptionally slim, just 19.9mm / 0.78″, the IdeaPad 3i Gen 7 laptop slips easily into any backpack or bag, making it perfect for on-the-go use. It also has an easy-to-carry design, ideal for when moving between meetings or rooms. And with its sleek hairline-sheet cover, available in Arctic Grey, Abyss Blue, and Misty Blue, it looks great wherever you go, too.",
                            FeaturePictureURL = "https://www.lenovo.com/medias/?context=bWFzdGVyfHJvb3R8NTQzNTJ8aW1hZ2UvcG5nfGg4Yy9oODQvMTQ3MzAxNjY1MDE0MDYuanBnfGRhOTMwOGQ2NmU0OWY3ZWMzY2JhMmRlZTVjNTAwMDdiYWRlYTg0ODg2ZmQwYjE2OTExNjhkODAzMDY3MDhkMTk&w=1920"
                        },
                        new Features()
                        {
                            FeatureName = "Small chip. Giant leap.",
                            Description = "M1 is our first chip designed specifically for Mac. Apple silicon integrates the CPU, GPU, Neural Engine, I/O and so much more onto a single tiny chip. Packed with an astonishing 16 billion transistors, M1 delivers exceptional performance, custom technologies and unbelievable power efficiency — a major breakthrough for Mac.",
                            FeaturePictureURL = "https://www.apple.com/v/macbook-air-m1/b/images/overview/apple_silicon_endframe__forvi6ykwn6m_large.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "Magic Keyboard Go ahead. Take the keys.",
                            Description = "When a keyboard types like a dream and still does a whole lot more, that’s magic. With preprogrammed shortcuts, useful features are easy to access. Get help from Siri, switch keyboard languages, respond with the perfect emoji, find documents with Spotlight — there’s so much you can do with just a tap. And the backlit keys with ambient light sensor help you type in low-light settings.",
                            FeaturePictureURL = "https://www.apple.com/v/macbook-air-m1/b/images/overview/magic_keyboard__pewz4toce72a_large.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "Dominating Specs",
                            Description = "Reign over the game world with the combined power of Intel Core i5 11th generation processor and NVIDIA GeForce RTX 3050 graphics. Ray tracing is the holy grail of gaming graphics, simulating the physical behaviour of light to bring real-time, cinematic-quality rendering to even the most visually intense games.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/46fe34a5-5032-4c13-98dd-0c85c7a26a88.__CR0,0,1000,1000_PT0_SX300_V1___.png"
                        },
                        new Features()
                        {
                            FeatureName = "High Speed Display",
                            Description = "Explore games in greater detail with the sharp visuals of a 15.6-inch FHD IPS display. Enjoy smooth, blur-free gameplay with a 144Hz refresh rate.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/9bf92896-7fed-4d30-af31-8e6f9cb05d76.__CR0,0,1000,1000_PT0_SX300_V1___.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "RGB all day",
                            Description = "Spice things up with the 4-zone RGB keyboard. WASD and arrow keys are also highlighted for easy visibility.",
                            FeaturePictureURL = "https://www.nbplaza.com.my/34408-large_default/acer-nitro-5-an515-57-71en-156-fhd-144hz-gaming-laptop-i7-11800h-16gb-512gb-ssd-rtx3060-6gb-w11-.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "Next-level performance",
                            Description = "Vivobook 16X is your eye-catching everyday companion that’s always ready to make light work of your agenda, whether it’s office or personal, presentations or play. For demanding workloads, the AMD Ryzen™ 5 5600H processor with 8 GB of fast memory and 512 GB of speedy SSD storage provide plenty of power in reserve when the going gets tough.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/6fea631f-ea02-4e04-9266-0777eff3a766.__CR0,0,300,300_PT0_SX300_V1___.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "Boost up your productivity",
                            Description = "Vivobook 16X delivers next-level performance from up to the latest AMD Ryzen™ 5 5600H processor to make every task easier, whether it’s streaming, browsing, editing, video chatting, or just taking care of business at home. Capable of a Turbo Boost speed of 4.2 GHz, it’s the fastest performing generation to date!",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/eabb501b-3a6b-4e8c-abb3-cf7a97261be1.__CR0,0,300,300_PT0_SX300_V1___.jpg"
                        },
                        new Features()
                        {
                            FeatureName = "Don’t be ordinary!",
                            Description = "VivoBook 16X is never ordinary, with a clean design and two eye-catching colors. Choose from charming Quiet Blue or distinguished Transparent Silver — whichever says ‘that’s me!’ It’s slim enough to pop unobtrusively into any backpack, and light enough for easy one-handed carrying.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/db4dc51f-25aa-4808-b83e-bafc92adb151.__CR0,0,300,300_PT0_SX300_V1___.jpg"
                        },
                         new Features()
                        {
                            FeatureName = "Experience Exceptional Visuals",
                            Description = "The powerful processor and graphics that saves your time and give you a seemless experience.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/I/81c5-h3uZyL._SX679_.jpg"
                        },
                         new Features()
                        {
                            FeatureName = "Stay Charged for Every Task",
                            Description = "Power up quickly with HP fast charge with up to 7 hours battery life(50% charge in 45 mins.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/I/81ZWKCi0ZsL._SX679_.jpg"
                        },
                         new Features()
                        {
                            FeatureName = "Engineered to crank up the action",
                            Description = "Guaranteed power: With up to AMD Processors, you can revel in powerful performance without interrupting your gaming, streaming or videos. Storage makes all the difference: Experience faster boot-ups with M.2 PCIe 512GB NVMe SSD. Full speed ahead: Intel Wi-Fi 6 AX201 ensure low latency gaming, smooth HD streaming video, and interruption-free voice and video chats.",
                            FeaturePictureURL = "https://i.dell.com/is/image/DellContent//content/dam/ss2/product-images/dell-client-products/notebooks/g-series/15-5515/anz/media-gallery/laptops_g-series_g15-5515-phantom-grey-coral-kb_gallery_4.psd?fmt=png-alpha&pscan=auto&scl=1&hei=402&wid=540&qlt=100,0&resMode=sharp2&size=540,402"
                        },
                         new Features()
                        {
                            FeatureName = "Game like you mean it",
                            Description = "Vivid sounds: Dual speakers with nahimic 3D Audio for Gamers let you hear every plan of attack with crisp clarity. Light it up: Game clearly in white, low-light setting with orange backlit keyboard WASD controlled by Alienware Command Center. Power that lasts: Don't let your gaming revolve around a plug; now you can quick-charge your system with a 56Whr battery.",
                            FeaturePictureURL = "https://img.giznext.com/assets/model/76/14313/profile/dell-g15-5515-gaming-laptop-ryzen-5-5800h-1656532649.JPG"
                        },
                         new Features()
                        {
                            FeatureName = "Progressive Design with Cutting Edge Display",
                            Description = "With its superior color ranging capabilities, this laptop ensures stunning display of colors on its FHD IPS display. Ease of access and a completely comfortable design allows you to maximize your machine’s potential. A compact laptop that brings life the visual experience with FHD, and Micro Edge bezel. A laptop with larger screen-to-body ratio, and Micro-edge bezels that maximize your view and make sure that you have crystal clear graphics and also a larger screen to enjoy your favourite videos.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/c1512ace-483e-483b-8b10-1d6a7ff25553.__CR0,0,1200,1200_PT0_SX300_V1___.jpg"
                        },
                          new Features()
                        {
                            FeatureName = "Enriched Audio",
                            Description = "Experience rich and authentic audio through the Bang & Olufsen Play. Each sound enriched to immerse you in a sound that takes you away. Combining it with the Dual HP Speakers & HP Audio Boost, brings to life each note and sound, be it when you’re listening to music or\r\n\r\nWatching a movie.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/3d8ca8ed-75b4-4274-8424-607bf083badc.__CR0,0,1200,1200_PT0_SX300_V1___.jpg"
                        },
                          new Features()
                        {
                            FeatureName = "Alexa Built-In",
                            Description = "The height of ease of living. With built in Alexa you can control your entertainment without any hassle. Ask and you shall get – be it the weather, or even your favorite song. All you need to do is ask.",
                            FeaturePictureURL = "https://m.media-amazon.com/images/S/aplus-media-library-service-media/e375a630-2d37-4e4f-9814-852957589832.__CR0,0,1200,1200_PT0_SX300_V1___.jpg"
                        },


                    });
                    context.SaveChanges();
                }
                //Laptop
                if (!context.Laptops.Any())
                {
                    context.Laptops.AddRange(new List<Laptop>()
                    {
                        new Laptop()
                        {
                            ModelName = "Vostro 3420",
                            ScreenSize = "14 Inches",
                            Price = 54090,
                            ImageURL = "https://m.media-amazon.com/images/I/6192pE7H2FL._AC_SS450_.jpg",
                            Colour = "Carbon Black",
                            CPUModel = "Core i5",
                            RAM = "8 GB",
                            OperatingSystem = "Windows 11",
                            CompanyID= 3
                        },
                        new Laptop()
                        {
                            ModelName = "IdeaPad 3 15IAU7",
                            ScreenSize = "15.6 Inches",
                            Price = 54990,
                            ImageURL = "https://d2xamzlzrdbdbn.cloudfront.net/products/a578eb9f-8253-41d8-b1f2-22068c7b0b0822061212.jpg",
                            Colour = "Arctic Grey ",
                            CPUModel = "Core i5",
                            RAM = "8 GB",
                            OperatingSystem = "Windows 11 Home",
                            CompanyID=1
                        },
                        new Laptop()
                        {
                            ModelName = "MacBook Air",
                            ScreenSize = "13 Inches",
                            Price = 92900,
                            ImageURL = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/macbook-air-gallery3-20201110?wid=2000&hei=1536&fmt=jpeg&qlt=95&.v=1632937845000",
                            Colour = "Gold",
                            CPUModel = "Core M Family",
                            RAM = "8 GB",
                            OperatingSystem = "MacOS 10.14 Mojave",
                            CompanyID=6
                        },
                        new Laptop()
                        {
                            ModelName = "AN515-57",
                            ScreenSize = "15.6 Inches",
                            Price = 59990,
                            ImageURL = "https://static-ecapac.acer.com/media/catalog/product/cache/a2e755bb2f5b00fa33d64eface9107e3/n/i/nitro5_an515-57_primary_image_3_2_4_1.jpg",
                            Colour = "Black",
                            CPUModel = "Core i5",
                            RAM = "8 GB",
                            OperatingSystem = "Windows",
                            CompanyID=2
                        },
                        new Laptop()
                        {
                            ModelName = "Vivobook 16X",
                            ScreenSize = "40.64 Centimeters",
                            Price = 54990,
                            ImageURL = "https://m.media-amazon.com/images/I/71EjVxkxwNL._SL1500_.jpg",
                            Colour = "Quiet Blue",
                            CPUModel = "Ryzen 5",
                            RAM = "8 GB",
                            OperatingSystem = "Windows 11 Home",
                            CompanyID=4
                        },
                        new Laptop()
                        {
                            ModelName = "15s-gr0012AU",
                            ScreenSize = "15.6 Inches",
                            Price = 41700,
                            ImageURL = "https://m.media-amazon.com/images/I/91gTXKjK8bL._SL1500_.jpg",
                            Colour = "Silver",
                            CPUModel = "Ryzen 3",
                            RAM = "8 GB",
                            OperatingSystem = "Windows 10 Home",
                            CompanyID=5
                        },
                        new Laptop()
                        {
                            ModelName = "G15-5515",
                            ScreenSize = "15.6 Inches",
                            Price = 75000,
                            ImageURL = "https://m.media-amazon.com/images/I/610sreKWXlL._SY450_.jpg",
                            Colour = "Phantom Grey with speckles",
                            CPUModel = "Ryzen 5",
                            RAM = "16 GB",
                            OperatingSystem = "Windows",
                            CompanyID=3
                        },
                        new Laptop()
                        {
                            ModelName = "HP Pavilion Laptop 15-eh 1101AU",
                            ScreenSize = "15.6 Inches",
                            Price = 54990,
                            ImageURL = "https://m.media-amazon.com/images/I/91Ef0M-lVOL._SL1500_.jpg",
                            Colour = "Silver",
                            CPUModel = "Ryzen 5",
                            RAM = "8 GB",
                            OperatingSystem = "Windows 11",
                            CompanyID=5
                        }
                    });
                    context.SaveChanges();

                }
                //Features & Laptops
                if (!context.Features_Laptops.Any())
                {
                    context.Features_Laptops.AddRange(new List<Features_Laptop>()
                    {
                        new Features_Laptop()
                        {
                            FeatureID = 1,
                            LaptopID = 1
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 2,
                            LaptopID = 1
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 3,
                            LaptopID = 2
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 4,
                            LaptopID = 2
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 5,
                            LaptopID = 2
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 6,
                            LaptopID = 3
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 7,
                            LaptopID = 3
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 8,
                            LaptopID = 4
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 9,
                            LaptopID = 4
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 10,
                            LaptopID = 4
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 11,
                            LaptopID = 5
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 12,
                            LaptopID = 5
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 13,
                            LaptopID = 5
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 14,
                            LaptopID = 6
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 15,
                            LaptopID = 6
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 16,
                            LaptopID = 7
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 17,
                            LaptopID = 7
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 18,
                            LaptopID = 8
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 19,
                            LaptopID = 8
                        },
                        new Features_Laptop()
                        {
                            FeatureID = 20,
                            LaptopID = 8
                        },
                    });
                    context.SaveChanges();


                }
            }
        }
    }
}
