namespace BDOnline.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BDOnline.Models.BDOnlineDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BDOnline.Models.BDOnlineDB context)
        {
            var Resources = new List<Models.Resource>
            {
                new Models.Resource{ ID=1, Name="MP"},
                new Models.Resource{ ID=2, Name="WP"},
                new Models.Resource{ ID=3, Name="SP"},
            };
            Resources.ForEach(rr => context.Resources.AddOrUpdate(r => r.ID, rr));
            context.SaveChanges();


            var Classes = new List<Models.Classes>
            {
                new Models.Classes{ ID=1,
                                    Name="Witch",
                                    Description="   Witches are known for their prudence in battle. In exchange for the casting time delay, they can perform large-scale magical attacks. Their thorough moves will burn, freeze and shatter their enemies with the power of natural elements such as fire, ice, wind, lightning, and earth. After Awakening, They can use the Aad Sphera to gain even great control over earth and lightning, and can summon the Earth and Lightning guardians.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_witch.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/e/e5/Witch_icon.png/revision/latest?cb=20160617191203",
                                    ResourceFK =1,
                },
                new Models.Classes{ ID=2,
                                    Name="Wizard",
                                    Description="   Wizards are known for their prudence in battle. In exchange for the casting time delay, they can perform large-scale magical attacks. Their thorough moves can burn, freeze and shatter their enemies with the power of natural elements such as fire, ice, wind, lightning, and earth. After Awakening, they can use the Godr Sphera to gain even greater control over fire and water to can even summon the Water and Fire Guardians.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_wizard.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/6/6a/Wizard_icon.png/revision/latest?cb=20160617191204",
                                    ResourceFK =1
                },
                new Models.Classes{ ID=3,
                                    Name="Kunoichi",
                                    Description="   Kunoichis use sword, martial arts, and Ninjutsu. Their swarm of attacks consists of swift movement, smoke shells, and unique skills such as hiding and pulling the enemy into the middle of total chaos. With proper control, a Kunoichi can flip the battle by discreetly raiding important figures. After Awakening, they can use the Sah Chakram to attack their enemies before they even realize what’s hit them.",
                                     Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_kunoichi.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/4/41/Kunoichi_icon.png/revision/latest?cb=20160617191059",
                                    ResourceFK = 1
                },
                new Models.Classes{ ID=4,
                                    Name="Ninja",
                                    Description="   Ninjas use sword, martial arts, and Ninjutsu. The swarm of attacks consisting of swift movement, smoke shells, and unique skills such as hiding and pulling the enemy into the middle of total chaos. With proper control, a Ninja can flip the battle by discreetly raiding important figures. After Awakening, they can use the Sura Katana to attack their enemies before they even realize what’s hit them.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_ninja.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/1/18/Ninja_icon.png/revision/latest?cb=20160617191101",
                                    ResourceFK = 2
                },
                new Models.Classes{ ID=5,
                                    Name="Maehwa",
                                    Description="   Maehwas fight with oriental-style martial arts and with the blade and horn bow. Maehwas are specialists in 1-on-1 showdowns, since their fast and precise attack combos can target enormous amount of damage at once. After Awakening, they use the Kerispear to deliver lethal stabs.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_maehwa.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/d/d4/Maehwa_icon.png/revision/latest?cb=20160617191059",
                                    ResourceFK = 2
                },
                new Models.Classes{ ID=6,
                                    Name="Musa",
                                    Description="   Musas fight with oriental-style martial arts and with the blade and horn bow. Musas are specialists in 1-on-1 showdowns, since their fast and precise attack combos can target enormous amount of damage at once. After Awakening, they can use the Crescent Blade to swiftly slice through their enemies.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_musa.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/0/09/Musa_icon.png/revision/latest?cb=20160617191100",
                                    ResourceFK = 2
                },
                new Models.Classes{ ID=7,
                                    Name="Striker",
                                    Description="   Strikers are hand-to-hand combatants who attained their skills through countless street brawls. From heavy punches to powerful kicks, their martial arts skills are matchless. After Awakening, they can use the Gardbrace on their both arms, and can also summon Echo Spirits to ambush their enemies from all sides.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_striker.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/0/06/Striker_icon.png/revision/latest?cb=20180410143917",
                                    ResourceFK = 2
                },
                new Models.Classes{ ID=8,
                                    Name="Mystic",
                                    Description="   Mystics are hand-to-hand combatants who attained their skills after countless years training in the East. From heavy punches to powerful kicks, their martial arts skills are matchless and elegant. After Awakening, they can channel the aura of the Sea Dragon to deliver powerful blows with the pair of Cestus on their arms.",
                                     Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_mystic.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/e/e5/Mystic_icon.png/revision/latest?cb=20180410143703",
                                    ResourceFK =2
                },
                new Models.Classes{ ID=9,
                                    Name="Valkyrie",
                                    Description="   Valkyries are armed with sword, shield, and divine magic. They can use their weapons to powerful blows to their enemies. They can also use their divine magic for healing and empowering allies. After Awakening, they can use Lancia, a weapon that is even taller than a Valkyrie and greatly boosts her great offense and defense.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_valkyrie.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/8/81/Valkyrie_icon.png/revision/latest?cb=20160617191105",
                                    ResourceFK = 3
                },
                new Models.Classes{ ID=10,
                                    Name="Warrior",
                                    Description="   Warriors are skilled fighters with both good attack and defense. Using the Sword and Shield as their main weapons, they are the best weapon-wielders among all the classes. During battle, Warriors will show off their fearlessness with storm-like barrage of melee combat moves. After Awakening, they use two-handed Great Swords to deliver devastating blows to their enemies.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_warrior.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/c/c8/Warrior_icon.png/revision/latest?cb=20160617191106",
                                    ResourceFK = 2
                },

                new Models.Classes{ ID=11,
                                    Name="Sorceress",
                                    Description="   Sorceresses can effectively control the battlefield with dark magic by using both melee and ranged attacks. They lure enemies with ranged magic and lead them to a chaos and painful demise once they come closer. Other races revere and fear the Sorceresses. After Awakening, they can use dark magic shroud themselves in darkness, and use a giant Scythe to cut down their enemies.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_sorceress.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/5/5f/Sorceress_icon.png/revision/latest?cb=20160617191103",
                                    ResourceFK = 1
                },
                new Models.Classes{ ID=12,
                                    Name="Tamer",
                                    Description="   Tamers can fight enemies at any range. With the support of Heilang, the divine beast, Tamers can perform ruthless combination attack with Heilang, or take the enemy down themselves while borrowing the divine force from the beast. After Awakening, they can use the Celestial Bo Staff to channel the divine power as the true master of Heilang.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_tamer.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/0/09/Tamer_icon.png/revision/latest?cb=20160617191104",
                                    ResourceFK = 1
                },
                new Models.Classes{ ID=13,
                                    Name="Ranger",
                                    Description="   Rangers are the specialists of ranged archery attacks. Under the grace of the Sylphs, Rangers present swift movement in any situation of battle. Most of their skills are based on preventing enemies' attempt of melee approach. The Sylph's mystic power is the source of their ability. After Awakening, they can wield the Kamasylven Sword to use melee type attacks.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_ranger.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/9/9c/Ranger_icon.png/revision/latest?cb=20160617191102",
                                    ResourceFK = 1
                },
                new Models.Classes{ ID=14,
                                    Name="Berserker",
                                    Description="   Berserkers wield monstrous double-axes as big as their own bodies. Berserkers overwhelm their enemies with their size and outrageous strength, annihilating them with ease. Although their physique makes them slow-moving, improved skills will compensate for that. After Awakening, they can use the Iron Buster to send powerful blasts at the enemy, almost like a small portable cannon.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_berserker.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/8/80/Berserker_icon.png/revision/latest?cb=20160617191058",
                                    ResourceFK =2
                },
                new Models.Classes{ ID=15,
                                    Name="Dark Knight",
                                    Description="   Dark Knights fight with the Kriegsmesser and magic. They tend to spring up at an enemy and strikes blows with the fearsome Kriegsmesser. They can use magic for mid- and long-distance for more damage. After Awakening, they can use the Vediant to freely switch between close and ranged attacks.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_darkknight.png",
                                    Ch_Symbol ="https://vignette.wikia.nocookie.net/blackdesert/images/3/32/DarkKnight2.png/revision/latest?cb=20170507194352",
                                    ResourceFK = 1
                                    },
                new Models.Classes{ ID=16,
                                    Name="Lahn",
                                    Description="   Lahns wield the Noble Sword and Crescent Pendulum. The Noble Sword and Crescent Pendulum are connected by a long cloth or chain, allowing Lahns to freely attack from all directions. Lahns are agile and quick on their feet, and can quickly deliver devastating attacks by swinging their Crescent Pendulum. By careful manipulation of the swinging motion, they can even deliver back attacks with the Crescent Pendulum from the front as well as various combo attacks.",
                                    Ch_image_fullBody ="https://akamai-webcdn.kgstatic.net/renewal/static/images/class/front_lahn.png",
                                    Ch_Symbol ="https://scontent.flis5-1.fna.fbcdn.net/v/t1.15752-9/37098432_546889735713653_7354020051353075712_n.png?_nc_cat=0&oh=22a5d21e83b1b5308b3b67cf413975b4&oe=5BD6927F",
                                    ResourceFK = 2
                }
            };
            Classes.ForEach(cc => context.Classess.AddOrUpdate(c => c.ID, cc));
            context.SaveChanges();


        }
    }
}
