using Terraria.ModLoader;
using Terraria.ID;

namespace SwapWorldSpecificItems
{
	public class SwapWorldSpecificItems : Mod
	{


		public override void AddRecipes()
		{
			//I am aware that this might not be the best place to do this, but i dont really care.

			//ores
			{
				{
					ModRecipe TinOre = new ModRecipe(this);     //copperore to tinore
					TinOre.AddIngredient(ItemID.CopperOre);
					TinOre.AddTile(TileID.WorkBenches);
					TinOre.SetResult(ItemID.TinOre);
					TinOre.AddRecipe();


					ModRecipe CopperOre = new ModRecipe(this);  //tinore to copperore
					CopperOre.AddIngredient(ItemID.TinOre);
					CopperOre.AddTile(TileID.WorkBenches);
					CopperOre.SetResult(ItemID.CopperOre);
					CopperOre.AddRecipe();

					ModRecipe TinBar = new ModRecipe(this);     //copperbar to tinbar
					TinBar.AddIngredient(ItemID.CopperBar);
					TinBar.AddTile(TileID.WorkBenches);
					TinBar.SetResult(ItemID.TinBar);
					TinBar.AddRecipe();

					ModRecipe CopperBar = new ModRecipe(this);  //tinbar to copperbar
					CopperBar.AddIngredient(ItemID.TinBar);
					CopperBar.AddTile(TileID.WorkBenches);
					CopperBar.SetResult(ItemID.CopperBar);
					CopperBar.AddRecipe();
				} //copper and tin
				{
					ModRecipe LeadOre = new ModRecipe(this);    //ironore to leadore
					LeadOre.AddIngredient(ItemID.IronOre);
					LeadOre.AddTile(TileID.Anvils);
					LeadOre.SetResult(ItemID.LeadOre);
					LeadOre.AddRecipe();

					ModRecipe IronOre = new ModRecipe(this);    //leadore to ironore
					IronOre.AddIngredient(ItemID.LeadOre);
					IronOre.AddTile(TileID.Anvils);
					IronOre.SetResult(ItemID.IronOre);
					IronOre.AddRecipe();

					ModRecipe LeadBar = new ModRecipe(this);    //ironbar to leadbar
					LeadBar.AddIngredient(ItemID.IronBar);
					LeadBar.AddTile(TileID.Anvils);
					LeadBar.SetResult(ItemID.LeadBar);
					LeadBar.AddRecipe();

					ModRecipe IronBar = new ModRecipe(this);    //leadbar to ironbar
					IronBar.AddIngredient(ItemID.LeadBar);
					IronBar.AddTile(TileID.Anvils);
					IronBar.SetResult(ItemID.IronBar);
					IronBar.AddRecipe();
				} //iron and lead
				{
					ModRecipe TungstenOre = new ModRecipe(this);        //Silverore to Tungstenore
					TungstenOre.AddIngredient(ItemID.SilverOre);
					TungstenOre.AddTile(TileID.Anvils);
					TungstenOre.SetResult(ItemID.TungstenOre);
					TungstenOre.AddRecipe();

					ModRecipe SilverOre = new ModRecipe(this);  //Tungstenore to Silverore
					SilverOre.AddIngredient(ItemID.TungstenOre);
					SilverOre.AddTile(TileID.Anvils);
					SilverOre.SetResult(ItemID.SilverOre);
					SilverOre.AddRecipe();

					ModRecipe TungstenBar = new ModRecipe(this);        //Silverbar to Tungstenbar
					TungstenBar.AddIngredient(ItemID.SilverBar);
					TungstenBar.AddTile(TileID.Anvils);
					TungstenBar.SetResult(ItemID.TungstenBar);
					TungstenBar.AddRecipe();

					ModRecipe SilverBar = new ModRecipe(this);  //Tungstenbar to Silverbar
					SilverBar.AddIngredient(ItemID.TungstenBar);
					SilverBar.AddTile(TileID.Anvils);
					SilverBar.SetResult(ItemID.SilverBar);
					SilverBar.AddRecipe();
				} //silver and tungsten
				{
					ModRecipe GoldOre = new ModRecipe(this);    //Platinumore to Goldore
					GoldOre.AddIngredient(ItemID.PlatinumOre);
					GoldOre.AddTile(TileID.Anvils);
					GoldOre.SetResult(ItemID.GoldOre);
					GoldOre.AddRecipe();

					ModRecipe PlatinumOre = new ModRecipe(this);    //Goldore to Platinumore
					PlatinumOre.AddIngredient(ItemID.GoldOre);
					PlatinumOre.AddTile(TileID.Anvils);
					PlatinumOre.SetResult(ItemID.PlatinumOre);
					PlatinumOre.AddRecipe();

					ModRecipe GoldBar = new ModRecipe(this);    //Platinumbar to Goldbar
					GoldBar.AddIngredient(ItemID.PlatinumBar);
					GoldBar.AddTile(TileID.Anvils);
					GoldBar.SetResult(ItemID.GoldBar);
					GoldBar.AddRecipe();

					ModRecipe PlatinumBar = new ModRecipe(this);    //Goldbar to Platinumbar
					PlatinumBar.AddIngredient(ItemID.GoldBar);
					PlatinumBar.AddTile(TileID.Anvils);
					PlatinumBar.SetResult(ItemID.PlatinumBar);
					PlatinumBar.AddRecipe();
				} //platinum and gold	
				{
					ModRecipe CrimtaneOre = new ModRecipe(this);        //Demoniteore to Crimtaneore
					CrimtaneOre.AddIngredient(ItemID.DemoniteOre);
					CrimtaneOre.AddTile(TileID.Anvils);
					CrimtaneOre.SetResult(ItemID.CrimtaneOre);
					CrimtaneOre.AddRecipe();

					ModRecipe DemoniteOre = new ModRecipe(this);    //Crimtaneore to Demoniteore
					DemoniteOre.AddIngredient(ItemID.CrimtaneOre);
					DemoniteOre.AddTile(TileID.Anvils);
					DemoniteOre.SetResult(ItemID.DemoniteOre);
					DemoniteOre.AddRecipe();

					ModRecipe CrimtaneBar = new ModRecipe(this);        //Demonitebar to Crimtanebar
					CrimtaneBar.AddIngredient(ItemID.DemoniteBar);
					CrimtaneBar.AddTile(TileID.Anvils);
					CrimtaneBar.SetResult(ItemID.CrimtaneBar);
					CrimtaneBar.AddRecipe();

					ModRecipe DemoniteBar = new ModRecipe(this);    //Crimtanebar to Demonitebar
					DemoniteBar.AddIngredient(ItemID.CrimtaneBar);
					DemoniteBar.AddTile(TileID.Anvils);
					DemoniteBar.SetResult(ItemID.DemoniteBar);
					DemoniteBar.AddRecipe();
				} //demonite to crimtane		
				{
					ModRecipe CobaltOre = new ModRecipe(this);      //Palladiumore to Cobaltore
					CobaltOre.AddIngredient(ItemID.PalladiumOre);
					CobaltOre.AddTile(TileID.Anvils);
					CobaltOre.SetResult(ItemID.CobaltOre);
					CobaltOre.AddRecipe();

					ModRecipe PalladiumOre = new ModRecipe(this);   //Cobaltore to Palladiumore
					PalladiumOre.AddIngredient(ItemID.CobaltOre);
					PalladiumOre.AddTile(TileID.Anvils);
					PalladiumOre.SetResult(ItemID.PalladiumOre);
					PalladiumOre.AddRecipe();

					ModRecipe CobaltBar = new ModRecipe(this);      //Palladiumbar to Cobaltbar
					CobaltBar.AddIngredient(ItemID.PalladiumBar);
					CobaltBar.AddTile(TileID.Anvils);
					CobaltBar.SetResult(ItemID.CobaltBar);
					CobaltBar.AddRecipe();

					ModRecipe PalladiumBar = new ModRecipe(this);   //Cobaltbar to Palladiumbar
					PalladiumBar.AddIngredient(ItemID.CobaltBar);
					PalladiumBar.AddTile(TileID.Anvils);
					PalladiumBar.SetResult(ItemID.PalladiumBar);
					PalladiumBar.AddRecipe();

				} //cobalt and palladium
				{
					ModRecipe MythrilOre = new ModRecipe(this);     //Orichalcumore to Mythrilore
					MythrilOre.AddIngredient(ItemID.OrichalcumOre);
					MythrilOre.AddTile(TileID.Anvils);
					MythrilOre.SetResult(ItemID.MythrilOre);
					MythrilOre.AddRecipe();

					ModRecipe OrichalcumOre = new ModRecipe(this);  //Mythrilore to Orichalcumore
					OrichalcumOre.AddIngredient(ItemID.MythrilOre);
					OrichalcumOre.AddTile(TileID.Anvils);
					OrichalcumOre.SetResult(ItemID.OrichalcumOre);
					OrichalcumOre.AddRecipe();

					ModRecipe MythrilBar = new ModRecipe(this);     //Orichalcumbar to Mythrilbar
					MythrilBar.AddIngredient(ItemID.OrichalcumBar);
					MythrilBar.AddTile(TileID.Anvils);
					MythrilBar.SetResult(ItemID.MythrilBar);
					MythrilBar.AddRecipe();

					ModRecipe OrichalcumBar = new ModRecipe(this);  //Mythrilbar to Orichalcumbar
					OrichalcumBar.AddIngredient(ItemID.MythrilBar);
					OrichalcumBar.AddTile(TileID.Anvils);
					OrichalcumBar.SetResult(ItemID.OrichalcumBar);
					OrichalcumBar.AddRecipe();

				} //mithril (all hail to the dwarves) and orichalcum 
				{
					ModRecipe AdamantiteOre = new ModRecipe(this);      //Titaniumore to Adamantiteore
					AdamantiteOre.AddIngredient(ItemID.TitaniumOre);
					AdamantiteOre.AddTile(TileID.MythrilAnvil);
					AdamantiteOre.SetResult(ItemID.AdamantiteOre);
					AdamantiteOre.AddRecipe();

					ModRecipe TitaniumOre = new ModRecipe(this);    //Adamantiteore to Titaniumore
					TitaniumOre.AddIngredient(ItemID.AdamantiteOre);
					TitaniumOre.AddTile(TileID.MythrilAnvil);
					TitaniumOre.SetResult(ItemID.TitaniumOre);
					TitaniumOre.AddRecipe();

					ModRecipe AdamantiteBar = new ModRecipe(this);      //Titaniumbar to Adamantitebar
					AdamantiteBar.AddIngredient(ItemID.TitaniumBar);
					AdamantiteBar.AddTile(TileID.MythrilAnvil);
					AdamantiteBar.SetResult(ItemID.AdamantiteBar);
					AdamantiteBar.AddRecipe();

					ModRecipe TitaniumBar = new ModRecipe(this);    //Adamantitebar to Titaniumbar
					TitaniumBar.AddIngredient(ItemID.AdamantiteBar);
					TitaniumBar.AddTile(TileID.MythrilAnvil);
					TitaniumBar.SetResult(ItemID.TitaniumBar);
					TitaniumBar.AddRecipe();

				} //adamantium and titanium
			}
			//evil things
			{
				{
					ModRecipe RottenChunk = new ModRecipe(this); //vertebrae to rottenchunk
					RottenChunk.AddIngredient(ItemID.Vertebrae);
					RottenChunk.AddTile(TileID.WorkBenches);
					RottenChunk.SetResult(ItemID.RottenChunk);
					RottenChunk.AddRecipe();

					ModRecipe Vertebrae = new ModRecipe(this); //rotten chunk to vertebrae
					Vertebrae.AddIngredient(ItemID.RottenChunk);
					Vertebrae.AddTile(TileID.WorkBenches);
					Vertebrae.SetResult(ItemID.Vertebrae);
					Vertebrae.AddRecipe();
				} //vertebrae and rottenchunk 				
				{
					ModRecipe CursedFlame = new ModRecipe(this); //Ichor to CursedFlame
					CursedFlame.AddIngredient(ItemID.Ichor);
					CursedFlame.AddTile(TileID.WorkBenches);
					CursedFlame.SetResult(ItemID.CursedFlame);
					CursedFlame.AddRecipe();

					ModRecipe Ichor = new ModRecipe(this); //CursedFlame to Ichor
					Ichor.AddIngredient(ItemID.CursedFlame);
					Ichor.AddTile(TileID.WorkBenches);
					Ichor.SetResult(ItemID.Ichor);
					Ichor.AddRecipe();
				} //ichor and cursedflame
				{
					ModRecipe ShadowScale = new ModRecipe(this); //TissueSample to ShadowScale
					ShadowScale.AddIngredient(ItemID.TissueSample);
					ShadowScale.AddTile(TileID.WorkBenches);
					ShadowScale.SetResult(ItemID.ShadowScale);
					ShadowScale.AddRecipe();

					ModRecipe TissueSample = new ModRecipe(this); //ShadowScale to TissueSample
					TissueSample.AddIngredient(ItemID.ShadowScale);
					TissueSample.AddTile(TileID.WorkBenches);
					TissueSample.SetResult(ItemID.TissueSample);
					TissueSample.AddRecipe();
				} //TissueSample and ShadowScale
				{
					ModRecipe VilePowder = new ModRecipe(this); //ViciousPowder to VilePowder
					VilePowder.AddIngredient(ItemID.ViciousPowder);
					VilePowder.AddTile(TileID.WorkBenches);
					VilePowder.SetResult(ItemID.VilePowder);
					VilePowder.AddRecipe();

					ModRecipe ViciousPowder = new ModRecipe(this); //VilePowder to ViciousPowder
					ViciousPowder.AddIngredient(ItemID.VilePowder);
					ViciousPowder.AddTile(TileID.WorkBenches);
					ViciousPowder.SetResult(ItemID.ViciousPowder);
					ViciousPowder.AddRecipe();
				} //ViciousPowder and VilePowder
				{
					ModRecipe CrimsonSeeds = new ModRecipe(this); //CorruptSeeds to CrimsonSeeds
					CrimsonSeeds.AddIngredient(ItemID.CorruptSeeds);
					CrimsonSeeds.AddTile(TileID.WorkBenches);
					CrimsonSeeds.SetResult(ItemID.CrimsonSeeds);
					CrimsonSeeds.AddRecipe();

					ModRecipe CorruptSeeds = new ModRecipe(this); //CrimsonSeeds to CorruptSeeds
					CorruptSeeds.AddIngredient(ItemID.CrimsonSeeds);
					CorruptSeeds.AddTile(TileID.WorkBenches);
					CorruptSeeds.SetResult(ItemID.CorruptSeeds);
					CorruptSeeds.AddRecipe();
				} //CorruptSeeds and CrimsonSeeds
				{
					ModRecipe VileMushroom = new ModRecipe(this); //ViciousMushroom to VileMushroom
					VileMushroom.AddIngredient(ItemID.ViciousMushroom);
					VileMushroom.AddTile(TileID.WorkBenches);
					VileMushroom.SetResult(ItemID.VileMushroom);
					VileMushroom.AddRecipe();

					ModRecipe ViciousMushroom = new ModRecipe(this); //VileMushroom to ViciousMushroom
					ViciousMushroom.AddIngredient(ItemID.VileMushroom);
					ViciousMushroom.AddTile(TileID.WorkBenches);
					ViciousMushroom.SetResult(ItemID.ViciousMushroom);
					ViciousMushroom.AddRecipe();
				} //ViciousMushroom and VileMushroom
				{
					ModRecipe CorruptFishingCrate = new ModRecipe(this); //CrimsonFishingCrate to CorruptFishingCrate
					CorruptFishingCrate.AddIngredient(ItemID.CrimsonFishingCrate);
					CorruptFishingCrate.AddTile(TileID.WorkBenches);
					CorruptFishingCrate.SetResult(ItemID.CorruptFishingCrate);
					CorruptFishingCrate.AddRecipe();

					ModRecipe CrimsonFishingCrate = new ModRecipe(this); //CorruptFishingCrate to CrimsonFishingCrate
					CrimsonFishingCrate.AddIngredient(ItemID.CorruptFishingCrate);
					CrimsonFishingCrate.AddTile(TileID.WorkBenches);
					CrimsonFishingCrate.SetResult(ItemID.CrimsonFishingCrate);
					CrimsonFishingCrate.AddRecipe();
				} //CrimsonFishingCrate and CorruptFishingCrate
				{
					ModRecipe EbonstoneBlock = new ModRecipe(this); //CrimstoneBlock to EbonstoneBlock
					EbonstoneBlock.AddIngredient(ItemID.CrimstoneBlock);
					EbonstoneBlock.AddTile(TileID.WorkBenches);
					EbonstoneBlock.SetResult(ItemID.EbonstoneBlock);
					EbonstoneBlock.AddRecipe();

					ModRecipe CrimstoneBlock = new ModRecipe(this); //EbonstoneBlock to CrimstoneBlock
					CrimstoneBlock.AddIngredient(ItemID.EbonstoneBlock);
					CrimstoneBlock.AddTile(TileID.WorkBenches);
					CrimstoneBlock.SetResult(ItemID.CrimstoneBlock);
					CrimstoneBlock.AddRecipe();

				} //EbonstoneBlock and CrimstoneBlock
				{
					ModRecipe EbonsandBlock = new ModRecipe(this); //CrimsandBlock to EbonsandBlock
					EbonsandBlock.AddIngredient(ItemID.CrimsandBlock);
					EbonsandBlock.AddTile(TileID.WorkBenches);
					EbonsandBlock.SetResult(ItemID.EbonsandBlock);
					EbonsandBlock.AddRecipe();

					ModRecipe CrimsandBlock = new ModRecipe(this); //EbonsandBlock to CrimsandBlock
					CrimsandBlock.AddIngredient(ItemID.EbonsandBlock);
					CrimsandBlock.AddTile(TileID.WorkBenches);
					CrimsandBlock.SetResult(ItemID.CrimsandBlock);
					CrimsandBlock.AddRecipe();
				} //EbonsandBlock and CrimsandBlock
				{
					ModRecipe CorruptHardenedSand = new ModRecipe(this); //CrimsonHardenedSand to CorruptHardenedSand
					CorruptHardenedSand.AddIngredient(ItemID.CrimsonHardenedSand);
					CorruptHardenedSand.AddTile(TileID.WorkBenches);
					CorruptHardenedSand.SetResult(ItemID.CorruptHardenedSand);
					CorruptHardenedSand.AddRecipe();

					ModRecipe CrimsonHardenedSand = new ModRecipe(this); //CorruptHardenedSand to CrimsonHardenedSand
					CrimsonHardenedSand.AddIngredient(ItemID.CorruptHardenedSand);
					CrimsonHardenedSand.AddTile(TileID.WorkBenches);
					CrimsonHardenedSand.SetResult(ItemID.CrimsonHardenedSand);
					CrimsonHardenedSand.AddRecipe();
				} //CorruptHardenedSand and CrimsonHardenedSand				
				{
					ModRecipe BandofStarpower = new ModRecipe(this); //PanicNecklace to BandofStarpower
					BandofStarpower.AddIngredient(ItemID.PanicNecklace);
					BandofStarpower.AddTile(TileID.WorkBenches);
					BandofStarpower.SetResult(ItemID.BandofStarpower);
					BandofStarpower.AddRecipe();

					ModRecipe PanicNecklace = new ModRecipe(this); //BandofStarpower to PanicNecklace
					PanicNecklace.AddIngredient(ItemID.BandofStarpower);
					PanicNecklace.AddTile(TileID.WorkBenches);
					PanicNecklace.SetResult(ItemID.PanicNecklace);
					PanicNecklace.AddRecipe();
				} //PanicNecklace and BandofStarpower				
				{
					ModRecipe Vilethorn = new ModRecipe(this); //CrimsonRod to Vilethorn
					Vilethorn.AddIngredient(ItemID.CrimsonRod);
					Vilethorn.AddTile(TileID.WorkBenches);
					Vilethorn.SetResult(ItemID.Vilethorn);
					Vilethorn.AddRecipe();

					ModRecipe CrimsonRod = new ModRecipe(this); //Vilethorn to CrimsonRod
					CrimsonRod.AddIngredient(ItemID.Vilethorn);
					CrimsonRod.AddTile(TileID.WorkBenches);
					CrimsonRod.SetResult(ItemID.CrimsonRod);
					CrimsonRod.AddRecipe();
				} //CrimsonRod and Vilethorn				
				{
					ModRecipe BallOHurt = new ModRecipe(this); //TheRottedFork to BallOHurt
					BallOHurt.AddIngredient(ItemID.TheRottedFork);
					BallOHurt.AddTile(TileID.WorkBenches);
					BallOHurt.SetResult(ItemID.BallOHurt);
					BallOHurt.AddRecipe();

					ModRecipe TheRottedFork = new ModRecipe(this); //BallOHurt to TheRottedFork
					TheRottedFork.AddIngredient(ItemID.BallOHurt);
					TheRottedFork.AddTile(TileID.WorkBenches);
					TheRottedFork.SetResult(ItemID.TheRottedFork);
					TheRottedFork.AddRecipe();
				} //TheRottedFork and BallOHurt				
				{
					ModRecipe ShadowOrb = new ModRecipe(this); //CrimsonHeart to ShadowOrb
					ShadowOrb.AddIngredient(ItemID.CrimsonHeart);
					ShadowOrb.AddTile(TileID.WorkBenches);
					ShadowOrb.SetResult(ItemID.ShadowOrb);
					ShadowOrb.AddRecipe();

					ModRecipe CrimsonHeart = new ModRecipe(this); //ShadowOrb to CrimsonHeart
					CrimsonHeart.AddIngredient(ItemID.ShadowOrb);
					CrimsonHeart.AddTile(TileID.WorkBenches);
					CrimsonHeart.SetResult(ItemID.CrimsonHeart);
					CrimsonHeart.AddRecipe();
				} //CrimsonHeart and ShadowOrb
				  //mimic loot				
				{
					ModRecipe DartRifle = new ModRecipe(this); //DartPistol to DartRifle
					DartRifle.AddIngredient(ItemID.DartPistol);
					DartRifle.AddTile(TileID.WorkBenches);
					DartRifle.SetResult(ItemID.DartRifle);
					DartRifle.AddRecipe();

					ModRecipe DartPistol = new ModRecipe(this); //DartRifle to DartPistol
					DartPistol.AddIngredient(ItemID.DartRifle);
					DartPistol.AddTile(TileID.WorkBenches);
					DartPistol.SetResult(ItemID.DartPistol);
					DartPistol.AddRecipe();
				} //DartPistol and DartRifle				
				{
					ModRecipe ChainGuillotines = new ModRecipe(this); //FetidBaghnakhs to ChainGuillotines
					ChainGuillotines.AddIngredient(ItemID.FetidBaghnakhs);
					ChainGuillotines.AddTile(TileID.WorkBenches);
					ChainGuillotines.SetResult(ItemID.ChainGuillotines);
					ChainGuillotines.AddRecipe();

					ModRecipe FetidBaghnakhs = new ModRecipe(this); //ChainGuillotines to FetidBaghnakhs
					FetidBaghnakhs.AddIngredient(ItemID.ChainGuillotines);
					FetidBaghnakhs.AddTile(TileID.WorkBenches);
					FetidBaghnakhs.SetResult(ItemID.FetidBaghnakhs);
					FetidBaghnakhs.AddRecipe();
				} //FetidBaghnakhs and ChainGuillotines				
				{
					ModRecipe ClingerStaff = new ModRecipe(this); //SoulDrain to ClingerStaff
					ClingerStaff.AddIngredient(ItemID.SoulDrain);
					ClingerStaff.AddTile(TileID.WorkBenches);
					ClingerStaff.SetResult(ItemID.ClingerStaff);
					ClingerStaff.AddRecipe();

					ModRecipe SoulDrain = new ModRecipe(this); //ClingerStaff to SoulDrain
					SoulDrain.AddIngredient(ItemID.ClingerStaff);
					SoulDrain.AddTile(TileID.WorkBenches);
					SoulDrain.SetResult(ItemID.SoulDrain);
					SoulDrain.AddRecipe();
				} //SoulDrain and ClingerStaff				
				{
					ModRecipe PutridScent = new ModRecipe(this); //FleshKnuckles to PutridScent
					PutridScent.AddIngredient(ItemID.FleshKnuckles);
					PutridScent.AddTile(TileID.WorkBenches);
					PutridScent.SetResult(ItemID.PutridScent);
					PutridScent.AddRecipe();

					ModRecipe FleshKnuckles = new ModRecipe(this); //PutridScent to FleshKnuckles
					FleshKnuckles.AddIngredient(ItemID.PutridScent);
					FleshKnuckles.AddTile(TileID.WorkBenches);
					FleshKnuckles.SetResult(ItemID.FleshKnuckles);
					FleshKnuckles.AddRecipe();
				} //FleshKnuckles and PutridScent				
				{
					ModRecipe WormHook = new ModRecipe(this); //TendonHook to WormHook
					WormHook.AddIngredient(ItemID.TendonHook);
					WormHook.AddTile(TileID.WorkBenches);
					WormHook.SetResult(ItemID.WormHook);
					WormHook.AddRecipe();

					ModRecipe TendonHook = new ModRecipe(this); //WormHook to TendonHook
					TendonHook.AddIngredient(ItemID.WormHook);
					TendonHook.AddTile(TileID.WorkBenches);
					TendonHook.SetResult(ItemID.TendonHook);
					TendonHook.AddRecipe();
				} //TendonHook and WormHook



			}
			//other miscellanous things
			{
				{
					ModRecipe GreenBrick = new ModRecipe(this);     //GreenBrick 1
					GreenBrick.AddIngredient(ItemID.BlueBrick);
					GreenBrick.AddTile(TileID.HeavyWorkBench);
					GreenBrick.SetResult(ItemID.GreenBrick);
					GreenBrick.AddRecipe();

					GreenBrick = new ModRecipe(this);               //GreenBrick 2
					GreenBrick.AddIngredient(ItemID.PinkBrick);
					GreenBrick.AddTile(TileID.HeavyWorkBench);
					GreenBrick.SetResult(ItemID.GreenBrick);
					GreenBrick.AddRecipe();

					ModRecipe BlueBrick = new ModRecipe(this);     //BlueBrick 1
					BlueBrick.AddIngredient(ItemID.GreenBrick);
					BlueBrick.AddTile(TileID.HeavyWorkBench);
					BlueBrick.SetResult(ItemID.BlueBrick);
					BlueBrick.AddRecipe();

					BlueBrick = new ModRecipe(this);                //BlueBrick 2
					BlueBrick.AddIngredient(ItemID.PinkBrick);
					BlueBrick.AddTile(TileID.HeavyWorkBench);
					BlueBrick.SetResult(ItemID.BlueBrick);
					BlueBrick.AddRecipe();

					ModRecipe PinkBrick = new ModRecipe(this);     //PinkBrick 1
					PinkBrick.AddIngredient(ItemID.BlueBrick);
					PinkBrick.AddTile(TileID.HeavyWorkBench);
					PinkBrick.SetResult(ItemID.PinkBrick);
					PinkBrick.AddRecipe();

					PinkBrick = new ModRecipe(this);                //PinkBrick 2
					PinkBrick.AddIngredient(ItemID.GreenBrick);
					PinkBrick.AddTile(TileID.HeavyWorkBench);
					PinkBrick.SetResult(ItemID.PinkBrick);
					PinkBrick.AddRecipe();


				} //dungeon bricks
			}


			base.AddRecipes();
		}
	}
}