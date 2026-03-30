using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using QuarkiesCards.Cards;
using QuarkiesCards.MonoBehaviours;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace QuarkiesCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class QuarkiesCards : BaseUnityPlugin
    {
        private const string ModId = "com.quarkie.rounds.QuarkiesCards";
        private const string ModName = "QuarkiesCards";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "QC";

        public static QuarkiesCards instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<MonoTest>(); // Repeat for each card to be built

        }
    }
}