using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fuyu.Backend.BSG.DTO.Profiles
{
    // Assembly-CSharp.dll: EFT.Profile
    [DataContract]
    public class Profile
    {
        [DataMember]
        public string _id;

        [DataMember]
        public int aid;

        [DataMember]
        public string savage;

        [DataMember]
        public ProfileInfo Info;

        [DataMember]
        public CustomizationInfo Customization;

        [DataMember]
        public HealthInfo Health;

        [DataMember]
        public InventoryInfo Inventory;

        [DataMember]
        public SkillInfo Skills;

        [DataMember]
        public StatsInfo Stats;

        [DataMember]
        public Dictionary<string, bool> Encyclopedia;

        [DataMember]
        public Dictionary<string, ConditionCounter> TaskConditionCounters;

        [DataMember]
        public InsuredItem[] InsuredItems;

        [DataMember]
        public HideoutInfo Hideout;

        [DataMember]
        public BonusInfo[] Bonuses;

        // TODO: proper type
        [DataMember]
        public object[] WishList;

        [DataMember]
        public NotesInfo Notes;

        [DataMember]
        public QuestInfo[] Quests;

        // TODO: proper type
        [DataMember]
        public Dictionary<string, string> Achievements;

        [DataMember]
        public RagfairInfo RagfairInfo;

        [DataMember]
        public Dictionary<string, TraderInfo> TradersInfo;

        [DataMember]
        public UnlockedInfo UnlockedInfo;

        [DataMember]
        public MoneyTransferLimitInfo moneyTransferLimitData;
    }
}