using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnitInfoSC : MonoBehaviour
{
    [HideInInspector] public string unitName;
    [HideInInspector] public string unitDes;
    [HideInInspector] public string unitNametoShow;
    [HideInInspector] public string unitDestoShow;

    #region Callback Zone
    public string GetUnitName(int unitID, int unitFaction)
    {
        unitName = "";

        if (unitFaction == 1)
        {
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo();
                    break;
                case 1:
                    MarineDes();
                    break;
                case 2:
                    RocketDes();
                    break;
                case 3:
                    EngineerDes();
                    break;
                case 4:
                    GhostDes();
                    break;
                case 5:
                    PaladinDes();
                    break;
                case 6:
                    TemplarsDes();
                    break;
                case 7:
                    TroncycleDes();
                    break;
                case 8:
                    SpiderDes();
                    break;
                case 9:
                    TaurosDes();
                    break;
                case 10:
                    ArmargeddonDes();
                    break;
                case 11:
                    QuadamoDes();
                    break;
                case 12:
                    SkyhammerDes();
                    break;
                case 13:
                    SkylynxDes();
                    break;
                case 14:
                    CondorDes();
                    break;
                case 15:
                    AC130Des();
                    break;
                case 16:
                    YamatoDes();
                    break;
                case 17:
                    TransportDes();
                    break;
                case 18:
                    YeagerDes();
                    break;
            }
        }
        else if (unitFaction == 2)
        {
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo(); break;
                case 1:
                    GrutDes(); break;
                case 2:
                    TrollDes();
                    break;
                case 3:
                    ParasiteDes(); break;
                case 4:
                    NazgullDes();
                    break;
                case 5:
                    FaclessDes(); break;
                case 6:
                    WarlockDes();
                    break;
                case 7:
                    CreeplingDes(); break;
                case 8:
                    YetiDes();
                    break;
                case 9:
                    ArachilingDes(); break;
                case 10:
                    MegarhinoxDes();
                    break;
                case 11:
                    DinoflakDes(); break;
                case 12:
                    OctapodDes();
                    break;
                case 13:
                    ApesDes(); break;
                case 14:
                    ZalakDes();
                    break;
                case 15:
                    CanonnestDes(); break;
                case 16:
                    MutaliskDes(); break;
                case 17:
                    GigaDes();
                    break;
                case 18:
                    SerperntDes(); break;
            }
        }
        else if (unitFaction == 3)
        {
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo(); break;
                case 1:
                    WarrirorDes(); break;
                case 2:
                    FlyfisherDes();
                    break;
                case 3:
                    ProbesDes(); break;
                case 4:
                    IronbornDes();
                    break;
                case 5:
                    CombatantDes(); break;
                case 6:
                    MermaidDes();
                    break;
                case 7:
                    LynwyrmDes(); break;
                case 8:
                    TakopodDes();
                    break;
                case 9:
                    HydraDes(); break;
                case 10:
                    SkyfallDes();
                    break;
                case 11:
                    CharybdisDes(); break;
                case 12:
                    BattleshipDes();
                    break;
                case 13:
                    AttacksubDes(); break;
                case 14:
                    AmphipreterDes();
                    break;
                case 15:
                    CarrierDes(); break;
                case 16:
                    MotherfortressDes(); break;
            }
        }
        return unitNametoShow = unitName;
    }
    public string GetUnitDes(int unitID, int unitFaction) 
    {
        unitDes = "";

        if (unitFaction == 1)
        {
            //This des for UIPM unit
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo(); 
                    break;
                case 1:
                    MarineDes(); 
                    break;
                case 2:
                    RocketDes();
                    break;
                case 3:
                    EngineerDes(); 
                    break;
                case 4:
                    GhostDes();
                    break;
                case 5:
                    PaladinDes();   
                    break;
                case 6:
                    TemplarsDes(); 
                    break;
                case 7:
                    TroncycleDes();
                    break;
                case 8:
                    SpiderDes();
                    break;
                case 9:
                    TaurosDes(); 
                    break;
                case 10:
                    ArmargeddonDes();
                    break;
                case 11:
                    QuadamoDes(); 
                    break;
                case 12:
                    SkyhammerDes();
                    break;
                case 13:
                    SkylynxDes(); 
                    break;
                case 14:
                    CondorDes(); 
                    break;
                case 15:
                    AC130Des();
                    break;
                case 16:
                    YamatoDes(); 
                    break;
                case 17:
                    TransportDes();
                    break;
                case 18:
                    YeagerDes(); 
                    break;
            }
        }
        else if (unitFaction == 2)
        {
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo(); break;
                case 1:
                    GrutDes(); break;
                case 2:
                    TrollDes();
                    break;
                case 3:
                    ParasiteDes(); break;
                case 4:
                    NazgullDes();
                    break;
                case 5:
                    FaclessDes(); break;
                case 6:
                    WarlockDes();
                    break;
                case 7:
                    CreeplingDes(); break;
                case 8:
                    YetiDes();
                    break;
                case 9:
                    ArachilingDes(); break;
                case 10:
                    MegarhinoxDes();
                    break;
                case 11:
                    DinoflakDes(); break;
                case 12:
                    OctapodDes();
                    break;
                case 13:
                    ApesDes(); break;
                case 14:
                    ZalakDes();
                    break;
                case 15:
                    CanonnestDes(); break;
                case 16:
                    MutaliskDes(); break;
                case 17:
                    GigaDes();
                    break;
                case 18:
                    SerperntDes(); break;
            }
        }
        else if (unitFaction == 3)
        {
            switch (unitID)
            {
                case 0:
                    ReturnNullInfo(); break;
                case 1:
                    WarrirorDes(); break;
                case 2:
                    FlyfisherDes();
                    break;
                case 3:
                    ProbesDes(); break;
                case 4:
                    IronbornDes();
                    break;
                case 5:
                    CombatantDes(); break;
                case 6:
                    MermaidDes();
                    break;
                case 7:
                    LynwyrmDes(); break;
                case 8:
                    TakopodDes();
                    break;
                case 9:
                    HydraDes(); break;
                case 10:
                    SkyfallDes();
                    break;
                case 11:
                    CharybdisDes(); break;
                case 12:
                    BattleshipDes();
                    break;
                case 13:
                    AttacksubDes(); break;
                case 14:
                    AmphipreterDes();
                    break;
                case 15:
                    CarrierDes(); break;
                case 16:
                    MotherfortressDes(); break;
            }
        }
        return unitDestoShow = unitDes;
    }
    private void ReturnNullInfo()
    {
        unitDes = null;
        unitName = null;
    }
    #endregion

    #region UIPM Unit Info
    private void MarineDes()
    {
        unitName = "Marine Squad";
        unitDes = "Every country exist in Earth and others human's colonies have their own military protection force even they being called as National Army or Colonies Protection Force but every countries and colonies must be donate their militant for UIPM's force as the law of UIPM and every personnel after confirm to join UIPM's army will be setting as a part of Marine units, as the lowest rank of UIPM army, they accidentally become the spine of UIPM army. For this role and for protecting a militant's life standing before multiple dangers on the battlefield, this force is one of a couple forces that are well equipped. The minimum condition to become a Marine for a militant is to reach sergeant rank in their local military force with a high military's attitude. Their commander will hand pick them every half-year, after being picked and become a Marine's candidate, they must spend next one month in UIPM Military Institute for multiple combat tests and learn more things for the new battlefield. If they pass this month, they will completely become a Marine of UIPM Army Force. For a humanoid, this is actually an honor.";
    }
    private void RocketDes()
    {
        unitName = "Photon Rocketer";
        unitDes = "The next level of Marine Knight Squad’s members. This unit is the guys who used to be Marine Knights who reach Squad's Leader Rank and choose to become a part of the new military's branch, no matter who they are or where they come from, even the empire's prisoners who are still in crime. They are able to keep their old armor - the personal device they have been allocated from the time they join UIPM Army. After a Marine Knight Squad member reach Squad's Leader rank for a period of time, they will receive a aspiration paper form that allow them to choose their future, they have three ways to choose their aspiration, they must be pick one among three of them, one is continue to work as Marine Knight Squad’s leader, serve army with that rank until they dead, retire or injured in battle, the second ones is leave army, complete their militant’s duty and back to normal life with this choice, they able to live as a civilian and die as civilian too, the final ways is become a Photon Rocketeer Squad’s member.\r\n";
    }
    private void EngineerDes()
    {
        unitName = "WARFIELD ENGINEER";
        unitDes = "Similar to Marines, Warfield Engineers seem to be the army's spine too. If Marnies represent the UIPM government fists, Engineer forces are its brain. People who become Warfield Engineer of UIPM army have the same point being forced to study for an “Professional Semester” which teaches about multiple Warfield Skills, this Semester being processed by Institute of War Sciene.";    
    }

    private void PaladinDes()
    {
        unitName = "PALADIN COMPANIES";
        unitDes = "UPDATE SOON!!";
    }

    private void GhostDes()
    {
        unitName = "GHOST RECON TEAM";
        unitDes = "UPDATE SOON!!";
    }

    private void TemplarsDes()
    {
        unitName = "ELITE TEMPLAR";
        unitDes = "UIPM is a cross-species force in The Reality Universe, therefore along with the main force of Humanity, other species need to donate their humans to add force for UIPM’s Army even the strongest species as Aiurists. Elite Templar is an individual who is already a militant of Aiurists Planet’s Defend/APD force. After this individual serves for an amount of time, they are able to join a force of candidates who will keep training to reach high honor terms - the Elite Templars, who will serve under UIPM’s army. As Elite Templars candidates, those Aiurists will be transported to Earth and go directly to Institutes located inside Camran City - UIPM’s capital city. In this place, those candidates will learn more things about field strategy, assassination, ambush, close-combat advance technique, multiple-target combat,... all of this being taught by High-Elders of Aiurists who work here. In the final semester, those Aiurists will earn their Elite Templar rank as their name and Blanc Templar for paper side, this rank equal to the Null Templar rank used for Human and some other races. Beside the term, they can get their special equipment - a high duty all white armor and their weapon.\r\n";
    }

    private void TroncycleDes()
    {
        unitName = "TRONCYCLE";
        unitDes = "UPDATE SOON";
    }

    private void SpiderDes()
    {
        unitName = "SPIDERTRONIC";
        unitDes = "Being developed as an anti-rebelation unit from Soviet III’s ages, this unit now serves under UIPM's army as an anti-infantry and anti light-armored unit, under Armored Walkers Branch, Spidertrons Managing Department, incharge by Head Commander of Spidertrons Division. This mechanic unit’s shape is based on a mix of scorpions and tarantulas. To simplify, a Spidertron is merged from three parts, one is the center part - The Cockpit Section, legs part - Legs Section and “tail” part - Combative Section. Center part is a complete pod that serves as the cockpit, allowing all three members of the pilots team control all of the unit's action. Eight of the mechanical legs are very durability, mobility, which are strong enough to hold the unit's cockpit. In case the combat zone is too narrow, those legs can stab through the wall to let the whole unit move on walls such as a spider. Oftenly, those pilots don’t use all eight legs, 4 of them are usually being folded under unit’s “belly”, this action not being mentioned in the manual or by order from their commander, however, this action not harm unit’s functioning or systems, otherwise this action let unit is more mobility on clear surface and save much amount of energy. Pilots just use all of eight legs at the time they need to climb walls. Last part is their tail section connects directly to the center part, this section contains multiple things to serve a combat purpose. First of all, there is actually a “tail '' developed based on the scorpion tail, mini-guns being mounted on the tips of the tail. These tails can rotate multi-direction, providing a high-rate of fire power. Ammo box is included in this part, with the power generator being put in this section too.\r\n";
    }

    private void TaurosDes()
    {
        unitName = "TAUROS MAIN BATTLE TANK";
        unitDes = "There are not many options for Field Commanders of UIPM forces, especially Field Commanders who prefer to use the Armored Division as main strike force. Not much choice for them in armored vehicle division force, due to this, those commanders decide to build a series of main battle tanks which can fight on many types of planet's surface to fill the gap of this important role. The MBT which is able to deal with many armored target types from light to medium armored have been created. UIPM's scientists and Head of Armored Division must combine many tank design schematics from many MBT prototypes from many military forces which serve under UIPM rule. As a result, the all new tank has a durable chassis, mobility with four chain drive, two at front and two in the back give the tank similar look with a lying down bull. On the turret, the main gun is located off to the right a little bit to allow the scanning machine to be installed off to the left. Off to the back, up top of the turret is a \"weapon platform\", this thing allows Tauros tanks to put a copy of targeted opponent's weapons which are being scanned by the scanner and \"material printing drones\". Due to \"Scanning and Copy\" ability, these activities make the Tauros division become the most deadly unit in an armor war. Although the advantage of UIPM Army Force is not land units, Tauros tank armor can't be seen inferior compared with Armored Arachilings and Takopod MBTs. The pros of scanning ability can be seen as a protection solution to protect tank' crew and an offset part for slow rate of fire. ";
    }

    private void ArmargeddonDes()
    {
        unitName = "ARMARGEDDON TANK";
        unitDes = "To fill the gap of heavy fire power on land and be balanced on the ground battlefield against LoVT forces's Megacolossus, The Armageddon Tank was made to serve as the heavy tank or advanced anti armored vehicle unit on the field. Do not be the same as other units, because of late production, Armageddon units being made along with multiple upgrade options packages. In fact, UIPM has started off a whole department just for research and developing upgrading functions for this tank. The tank has its own unique design based on the shape of the Tauros tank with four wheel double-chain drive and un-balance turret but more bigger. The wheel double-chain drives system being installed on a large chassis, this four-double-chain drive allows Armageddon more easily to crane on anything and crush them or move on bad terrain. The turret is a complex area, on the left side, the turret is mounted by a group of three cannon and the right side is another bigger cannon, on the back side, the tank has itself an construct flat-platform where commanders can put their upgrade option on them.\r\n";
    }

    private void QuadamoDes()
    {
        unitName = "QUADAMO HYDROFOIL";
        unitDes = "UPDATE SOON";
    }

    private void SkyhammerDes()
    {
        unitName = "SKYHAMMER VTOL GUNSHIP";
        unitDes = "UPDATE SOON";
    }

    private void SkylynxDes()
    {
        unitName = "SKYLYNX MULTIPURPOSE WALKER";
        unitDes = "UPDATE SOON";
    }

    private void CondorDes()
    {
        unitName = "CONDOR BOMBER";
        unitDes = "UPDATE SOON";
    }

    private void AC130Des()
    {
        unitName = "AC130 EARTH BROKER";
        unitDes = "UPDATE SOON";
    }

    private void YamatoDes()
    {
        unitName = "YAMATO SPACECRUISER";
        unitDes = "UPDATE SOON";
    }

    private void TransportDes()
    {
        unitName = "HAVOOK STRANSPORTER";
        unitDes = "UPDATE SOON";
    }

    private void YeagerDes()
    {
        unitName = "YEAGER";
        unitDes = "UPDATE SOON";
    }
    #endregion

    #region LoVT Unit Info
    private void GrutDes()
    {
        unitName = "BRUTES GRUNTS";
        unitDes = "Angry, combative, strong, muscular. Those adjective is all talk about Brutes Grunt, a common name used for all Orgarnians joining the force of Legions as frontline ground units. They were a species of chaos exist on Ckaus planet. Separate, fighting each other for fun and conquering each other's properties until Princess of The Void came andturning them into a united species by force and torture. Although they still fight each other, at least, they don't beat their opponent to death as in the past. After conquered, Princess of the void still let them fight as their will by let them join frontline force or let them challenge each other but kill other Organian member is banned, as the law, anyone who kill other Organian will be brought to the Void, leave them there to dead or just being tear apart by The Void's hunter such as Kazik. There was four types of Organians now so every platoon of Brutes Grunt had four members in order: Green - Red - Pale - Black to serve multiple roles inside a platoon. The most strong and biggest is Green ones, with massive body to compare with the three remain, the Green one will serve as a shield for the platoon, Red one is the most muscular, although they are smaller the Green one, they are more stronger and more muscular, they are main strike force for the platoon, Pale one is carrier, who has responsibility to carrying team's equipment such as weapon and the Black one is the most intelligent Orgainan in a platoon, who will decide how team will fight in combat or take directly orders from battlefield commanders.";
    }
    private void TrollDes()
    {
        unitName = "ARMORHENTER TROLL";
        unitDes = "Originally, Troll is actually an Orc. Following the long periods of Orc’s growing time, the concept of “Troll” was formed and became the name of a specific species in the Universe. Sharing the same living space with Orcs on [...] planet. Long ago before, after Creation of World, a small group of Green Orc choose to learn magic and use it as weapon rather than muscular like what Orcs does, this cause the Orcs call Trolls is coward one and follow the time, Orcs throw hatred on Trolls. Because they choose to use magical rather muscular-like Orc, Troll is not thick and muscular like Orc does and due, they are tiny to compare with Orc, although some races of Troll are bigger than Orc, they are fluffy. Unlike Orc whose uses blunt melee weapons, Trolls prefer ranged weapons with enchanted magic on it, this “magic enchanted range weapon” causes them to be more accurate and more destructible when hit by a biological target. Orc being separated as many clans, Trolls is an united social, leader of the social call themself the Trollord, who incharge of manage the whole socials and just like Orc, the strongest Troll is Trollord, every Troll want to become Trollord, they just ask for a competition.";
    }
    private void ParasiteDes()
    {
        unitName = "PARASITE SLAVE";
        unitDes = "As the labor force of the whole LoVT's army, this force will donate their life to serve the Legion. This force being comes from many ways, some of them are war prisoners or peoples from multiple races who were imprisoned by the time Legions's army conquer their territories but not much because Legion’s militants usually prefer to kill their enemies rather than keep them as prisoners. Other sources of this force come directly from the Legion's army. Some of them are injured militants, captured betrayers, militant’s dead bodies, etc…  In fact, as unit's name, they are not actually a species exist in universe, ever in The Void, they are parasite which being made during the exist of Command Hive, those parasites exist as a type of mold grown from The Creep. Being spread and floating in the air by militants's step on The Creep surface, this molds secretly infect their host, almost all of LoVT’s militants are host of this parasite type. Those parasites after infiltrating their host through breath will latch on their host’s cortical and stay there quietly. Till their host being throw their last breath, those parasites will consume their host flesh immediately, use their host's original bone structure and amount of flesh being consumed to form a new body, turn their host's dead body to a completely thing called Parasite Slaves. Sometimes, this slave force can force their host to change to Parasite Slavers by an order being sent by the Command Hive. Although those parasite molds can infiltrate their host by breathing, some units can resist this infiltration by their default immune system, most of them are come from Undead TriClan, usually those are Dark Warlock. Some high rank Orgarnian are immune to these molds, after reaching the Overlord rank, they can ask for a favor from their commander to remove those parasite molds forever. ";
    }
    private void NazgullDes()
    {
        unitName = "NAZGULL SOULTAKER";
        unitDes = "To balance the scale of the battlefield, the Warlocks have been given an idea to add this force into the LoVT arsenal, the request has been confirmed. Nazgul Soultaker on one hand they serve as a unit in LoVt such as other units but in fact they are actually servants for Dark Warlocks. Following their term, they are Soultakers, who are in charge of soul collecting tasks. This task actually boosts Warlock's powers by continuing to add more and more souls to Warlock’s power pools. One Warlock controls a number of Nazgull Soultakers with master-servant relationships. Every Warlock will have their own “cage” to store collected souls, Nazgull Soultakers just need to capture souls from enemies, souls transfer tasks will be done after they get back Warlocks' mansion. This soultaker force can be seen as an otherside of a coin to compare with Paladin Companies. They are the dark of demons, Paladins is the light of gods.";
    }
    private void FaclessDes()
    {
        unitName = "THE FACLESS SOCIALS";
        unitDes = "None know about their history or even original founding of force, the think people know about them is their dangerous on battlefield, they like a flash, as someone said, they have Shinobi original because their costume, the other said they are blessed by dark magic and power of the void so they like a wind. But the truth isn't known. The only one who know about them is Queen of the Void and their training mentors but they still being a secret to the whole universe.";
    }
    private void WarlockDes()
    {
        unitName = "DARK WARLOCK";
        unitDes = "Oftenly, they are the master of their own clan. After being conquered by the Princess of the Void, those Warlocks as a part of Lycoris species are forced to join into a united race called the United of Sorcerers. For the early times being forced to unify , those warlocks show a disagreement for being seen on the same level with The Lich species and The Ergersiers species. To solve this dissent, PoTV have been allow those Warlocks have their own rights and properties lands, after that, those Warlock establish their own clan, so the number of Dark Warlock is very low but their power is can’t be underrate, the consequence unwittingly made them a high value asset in LoVT army but PoTV seem not to be comfort with this. In fact, the Nazgull Soultaker units are under control of those Warlocks, they are sworn to fealty under their master - the Warlocks. Those Warlocks have been asking PoTV to add Nazgull Soultaker to the formation LoVT army to fill the lack of cavalry slots but the truth is collecting souls for them. Under the look of LoVT, if all those Warlocks are colluding with each other, they can usurp her ruling easily.";
    }
    private void CreeplingDes()
    {
        unitName = "ARMORED CREEPLING";
        unitDes = "If Brutes Grunt is a pawn unit of the infantry side, Creeplings is an armored side's pawn. This unit is a foundation element of the whole Zerrus species, they can evolve to multiple race of Zerrus species base on their special DNA, although they exist with that important role, they are still a pawn unit because of their outnumbered individual when compare to others, their number always staying at 50 to 60 percent of Zerreus specie. Everytime they hatch out of their cocoon, they appear as four subjects but only one of them is able to evolve to a higher race. The three subjects remaining still stay at Creeplings races, they can serve as a specific race, or worse, become higher race food. To minimize this waste, PoTV split them into three groups at the time they step out of their cocoon. One is the group that contains possible-evolved-subjects, one is the Creeplings group and the other is the feeding-group. Individuals that belong to Creeplings group will be keep alive until being release on the battlefield, they have 50-50 chance to survive in the battlefield, in case of dead, they will be turn to food for other Creeplings, if they still alive, they will be under noticeable, through a couple more of battle, if they still survive, they will be add to possible-evolve-subjects.\r\n";
    }
    private void YetiDes()
    {
        unitName = "YETIGIANTS";
        unitDes = "UPDATE SOON";
    }
    private void ArachilingDes()
    {
        unitName = "ARMORED ARACHILING";
        unitDes = "An next evolution step in Zerrus’s evolution tree. Armored Arachilings is a unit that evolved from Armored Creeplings. After one Creeplings is consumed by the other with matching DNA string, they will be turned into Armored Arachilings quickly. Based on the original amount of armor skin resources and flesh pool from the two Creeplings which consume each other, Arachilings evolve their skin into a new level of armor. They use their extraordinary bone structure to form an armor which replaces the armor skin of Creeplings. Their muscles will evolve too, more muscles grow up, especially back muscles where they push out their corrosive spiky-spines which seem to be a side effect on Creeplings. Arachilings sense is very sensitive, they are a true moving radar, they can detect enemy targets from a long distance, let them prepare and be ready to deal with incoming targets. This sense allow then to detect aircraft too, turn them in a basic anti armor/anti aircraft unit of LoVT mean they can deal with light and medium-slow moving aircraft such like UIPM Viking, Hammerhead or Nargar Wyrm, in fact Arachilings still can attack fast moving aircraft such like bombers or heavy armor target like Yamato Spacruiser but seem not very effective much. As a bionic unit, Arachilings are very mobilized compared to its counterpart but they are easy to deal with because they are pretty weak. In some cases, a unit with a fire-based weapon can easily deal with Arachilings.\r\n";
    }
    private void MegarhinoxDes()
    {
        unitName = "ARMORED MEGARHINOX";
        unitDes = "UPDATE SOON";
    }
    private void DinoflakDes()
    {
        unitName = "DINOFLAK";
        unitDes = "UPDATE SOON";
    }
    private void OctapodDes()
    {
        unitName = "OCTAPOD";
        unitDes = "UPDATE SOON";
    }
    private void ApesDes()
    {
        unitName = "KNUCLEAPES";
        unitDes = "UPDATE SOON";
    }
    private void ZalakDes()
    {
        unitName = "ZALAK CARAVEL";
        unitDes = "UPDATE SOON";
    }
    private void CanonnestDes()
    {
        unitName = "CANNONEST GALEON";
        unitDes = "UPDATE SOON ";
    }
    private void MutaliskDes()
    {
        unitName = "MUTALISK AIRBORN";
        unitDes = "UPDATE SOON";
    }
    private void GigaDes()
    {
        unitName = "GIGA AIRSHIP";
        unitDes = "UPDATE SOON";
    }
    private void SerperntDes()
    {
        unitName = "GALACTIC SERPERT";
        unitDes = "UPDATE SOON";
    }
    #endregion

    #region NEA Unit Info
    private void WarrirorDes()
    {
        unitName = "Nargarian Warriors";
        unitDes = "As a part of the Nargarian Emperor Army (not to be confused with the Empire Army), they are special people with great performence among multiple militants throughout the Empire Army. They have been hand picked and asked to join the Nargarian Emperor for the first situation - the Emporium Warrior. Those brave and loyalty one, always be ready to sacrifice themself to serve the orders of the Nagarian’s king";
    }
    private void FlyfisherDes()
    {
        unitName = "FLYFISHER";
        unitDes = "Mermaids who fly through battlefields like birds. To provide anti aircraft fire power, this group of female soldiers are ones who want to serve as a militant but do not match the requirement for Shireens role. ";
    }
    private void ProbesDes()
    {
        unitName = "PROBES THE WORKER";
        unitDes = "Like every army that has been and will exist, there is always a workforce dedicated to building and gathering resources, Probes is an example. The Probes are specialized units responsible for building constructions for defense as well as production, besides Probes are also responsible for collecting resources and minerals to operate the army, unlike the other two units. On the opposite side are Warfield Engineer and Parasyte Slave.";
    }
    private void IronbornDes()
    {
        unitName = "IRONBORN THE SEAKNIGHT";
        unitDes = "UPDATE SOON";
    }
    private void CombatantDes()
    {
        unitName = "FISHMEN THE COMBATANT";
        unitDes = "Fishman Combatan/FC is a special force of NEA's army. Being built as a magical-base army, including Fishman Combatant as a truth, FC uses their extremely Qi and skilled hand to hand combat skill to deal with all-light-armor units, no matter what they are. ";
    }
    private void MermaidDes()
    {
        unitName = "SHIREEN NO MERMAID";
        unitDes = "From the deepest ocean floor to the highest ground where every Nargarian is able to reach, no one do not know about a force of female warriors called “The Shiren no Mermaids”. They are the most beautiful (as Nargarian standard), the braves ones, the smartest female among Nargarian female still alive. All of them are Mid-Born Nargarian, none of Low-Born able to join this force. Every single person who joins this force is the one that has been hand picked when they are very young by the Head Director of Mermaid Combatant Academy. Their parents must raise them with the military style and must be ready for the day they reach adult ages, the government will provide all grown fees. Reached adult ages, they will be forced to join “Shiren no Mermaids” force no matter if they want it or not, from this point, they are no longer their parents' child, even if they are K.I.A, their parents will not know anything about this information at all. All of “Shiren no Mermaids'' candidates will rally at Royal Family Palace as a presentation every year, after this presentation, they will be moved to Mermaid Combatant Academy and be forward to Training Camp - a colony planet of Empire, destination of training planet being changed every year but the same thing between them is small, harsh and dangerous. Although the training semester is short, just up to 3 months in the Nargarian calendar, the one who is able to survive these three months is able to survive every kind of battlefield they are working on in the future, high risk environment as always. They know every fighting style, they have a high strategy look, high IQ in battle, they know how to handle almost all situation in a war, in fact, this unit have enough skill to against a squad of Elite Templer from UIPM force or even Dark Warlock who can control they prey’s mental. Along with high combat skills, they are still good doctors for the whole Empire Army. In three months of training, they have two weeks being taught how to heal others. In fact, the best way to heal a Nargarian from the injured is matching with them, the more skilled in matching, the more the injured can heal. So for this healing purpose, every personnel of Siren no Mermaid's force will be able to disable their fertility.";
    }
    private void LynwyrmDes()
    {
        unitName = "LYNWYRM SEADRAGON";
        unitDes = "UPDATE SOON";
    }
    private void TakopodDes()
    {
        unitName = "TAKOPOD AMPHIBIOUS TANK";
        unitDes = "To deal with Tauros MBT and Arachilings, NEA must make their MBT, many prototypes of MBT being made, after all of them, just only one prototype being chosen by NEA general and head of War Dept. The Takopod. Due to its name, this MBT is a cyborg creature that can move both on land and sea as a submerging. At the point NEA have their Takopods, multiple outposts of UIPM have been overrun easily. This unit is able to do a melee attack on their target, if the enemy's vehicle is close enough, they can use their eight tentacles to squeeze their enemies to destroy.";
    }
    private void HydraDes()
    {
        unitName = "HYDRA LEVIATHAN";
        unitDes = "UPDATE SOON";
    }
    private void SkyfallDes()
    {
        unitName = "SKYFALL LEVIATHAN";
        unitDes = "UPDATE SOON";
    }
    private void CharybdisDes()
    {
        unitName = "CHARYBDIS LEVIATHAN";
        unitDes = "UPDATE SOON";
    }
    private void BattleshipDes()
    {
        unitName = "MEGALODORUS BATTALESHIP";
        unitDes = "As a conquering species through the universe, the Nargarian Empire army needs one thing to see it as a signature of the whole army and a thing that provides a mobile command post for all their navy units such as their naval fleet, Megalodoras being made for their pride. Massive, huge, powerful fire power, this battleship is able to conquer every sea zone of every planet it passes by, no matter how harsh they are, this battleship’s crew and itself do not care much about. This battleship is made of two parts, the main ship body and their “engine”. Not like any ship that people ever know, this battleship being dragged by two Megalodoras - a type of Leviathans that live on Nargar planet. Those Megalodoras are huge and strong enough to drag the huge ship’s body. And when those two massive monsters are released, they will become a bioshield of the ship itself beside it's magical shield, destroying any kind of threat that surrounds the ship. Sometimes in a battle, the ship's captain may order the crew to release those monsters too to provide fire support for the ship and fleet.";
    }
    private void AttacksubDes()
    {
        unitName = "NARATARAS ATTACKSUBMARINE";
        unitDes = "UPDATE SOON";
    }
    private void CarrierDes()
    {
        unitName = "KRAKEN CARRIER";
        unitDes = "UPDATE SOON";
    }
    private void MotherfortressDes()
    {
        unitName = "DORRUDON MOTHERFORTRESS";
        unitDes = "UPDATE SOON";
    }
    private void AmphipreterDes()
    {
        unitName = "AMPHIPRETER SKYSTRIKER";
        unitDes = "UPDATE SOON";
    }
    #endregion
}
