using System.Xml.Serialization;

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/DS_BTDRS.xsd", IsNullable = false)]
public partial class DS_BTDRS
{

    private object[] itemsField;

    /// <comentarios/>
    [System.Xml.Serialization.XmlElementAttribute("Locations", typeof(DS_BTDRSLocations))]
    [System.Xml.Serialization.XmlElementAttribute("MechLocation", typeof(DS_BTDRSMechLocation))]
    [System.Xml.Serialization.XmlElementAttribute("MechPilots", typeof(DS_BTDRSMechPilots))]
    [System.Xml.Serialization.XmlElementAttribute("MechWeaponLocation", typeof(DS_BTDRSMechWeaponLocation))]
    [System.Xml.Serialization.XmlElementAttribute("Mechs", typeof(DS_BTDRSMechs))]
    [System.Xml.Serialization.XmlElementAttribute("Weapons", typeof(DS_BTDRSWeapons))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSLocations
{

    private int locationIDField;

    private string descriptionField;

    /// <comentarios/>
    public int LocationID
    {
        get
        {
            return this.locationIDField;
        }
        set
        {
            this.locationIDField = value;
        }
    }

    /// <comentarios/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSMechLocation
{
        private int mechLocationIDField;
        private int mechIDField;
        private int locationIDField;
        private int hitPointsField;
        private bool hitPointsFieldSpecified;

    /// <comentarios/>
    public int MechLocationID
    {
        get
        {
            return this.mechLocationIDField;
        }
        set
        {
            this.mechLocationIDField = value;
        }
    }

    /// <comentarios/>
    public int MechID
    {
        get
        {
            return this.mechIDField;
        }
        set
        {
            this.mechIDField = value;
        }
    }

    /// <comentarios/>
    public int LocationID
    {
        get
        {
            return this.locationIDField;
        }
        set
        {
            this.locationIDField = value;
        }
    }

    /// <comentarios/>
    public int HitPoints
    {
        get
        {
            return this.hitPointsField;
        }
        set
        {
            this.hitPointsField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HitPointsSpecified
    {
        get
        {
            return this.hitPointsFieldSpecified;
        }
        set
        {
            this.hitPointsFieldSpecified = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSMechPilots
{

    private int pilotIDField;

    private bool pilotIDFieldSpecified;

    private string nameField;

    private string callsignField;

    private string affiliationField;

    private string rankField;

    private string descriptionField;

    private int pilotingSkillField;

    private bool pilotingSkillFieldSpecified;

    private int gunnerySkillField;

    private bool gunnerySkillFieldSpecified;

    private int hitPointsField;

    private bool hitPointsFieldSpecified;

    private int damageTakenField;

    private bool damageTakenFieldSpecified;

    private int killsField;

    private bool killsFieldSpecified;

    private string statusField;

    /// <comentarios/>
    public int PilotID
    {
        get
        {
            return this.pilotIDField;
        }
        set
        {
            this.pilotIDField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PilotIDSpecified
    {
        get
        {
            return this.pilotIDFieldSpecified;
        }
        set
        {
            this.pilotIDFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <comentarios/>
    public string Callsign
    {
        get
        {
            return this.callsignField;
        }
        set
        {
            this.callsignField = value;
        }
    }

    /// <comentarios/>
    public string Affiliation
    {
        get
        {
            return this.affiliationField;
        }
        set
        {
            this.affiliationField = value;
        }
    }

    /// <comentarios/>
    public string Rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }

    /// <comentarios/>
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <comentarios/>
    public int PilotingSkill
    {
        get
        {
            return this.pilotingSkillField;
        }
        set
        {
            this.pilotingSkillField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PilotingSkillSpecified
    {
        get
        {
            return this.pilotingSkillFieldSpecified;
        }
        set
        {
            this.pilotingSkillFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int GunnerySkill
    {
        get
        {
            return this.gunnerySkillField;
        }
        set
        {
            this.gunnerySkillField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool GunnerySkillSpecified
    {
        get
        {
            return this.gunnerySkillFieldSpecified;
        }
        set
        {
            this.gunnerySkillFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int HitPoints
    {
        get
        {
            return this.hitPointsField;
        }
        set
        {
            this.hitPointsField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HitPointsSpecified
    {
        get
        {
            return this.hitPointsFieldSpecified;
        }
        set
        {
            this.hitPointsFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int DamageTaken
    {
        get
        {
            return this.damageTakenField;
        }
        set
        {
            this.damageTakenField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DamageTakenSpecified
    {
        get
        {
            return this.damageTakenFieldSpecified;
        }
        set
        {
            this.damageTakenFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Kills
    {
        get
        {
            return this.killsField;
        }
        set
        {
            this.killsField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool KillsSpecified
    {
        get
        {
            return this.killsFieldSpecified;
        }
        set
        {
            this.killsFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSAmmo
{
    private int ammoID;
    private string ammoName;
    private string ammo;
    private decimal tons;
    private int cost;
    private int bv;

    /// <comentarios/>
    public int AmmoID
    {
        get
        {
            return this.ammoID;
        }
        set
        {
            this.ammoID= value;
        }
    }

    public string AmmoName
    {
        get { return this.ammoName; }
        set { this.ammoName = value; }
    }

    public string Ammo
    { get { return this.ammo;}
    set { this.ammo = value; }
    }

    public decimal Tons
    {
        get { return this.tons; }
        set { this.tons =value; }
    }

    public int Cost
    {
        get { return this.cost; }
        set { this.cost = value; }
    }
    public int BV
    {
        get { return this.bv; }
        set { this.bv = value; }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSMechWeaponLocation
{

    private int mechWeaponLocationIDField;

    private int mechLocationIDField;

    private int weaponIDField;

    private int ammoSpentField;

    private bool ammoSpentFieldSpecified;

    private string statusField;

    /// <comentarios/>
    public int MechWeaponLocationID
    {
        get
        {
            return this.mechWeaponLocationIDField;
        }
        set
        {
            this.mechWeaponLocationIDField = value;
        }
    }

    /// <comentarios/>
    public int MechLocationID
    {
        get
        {
            return this.mechLocationIDField;
        }
        set
        {
            this.mechLocationIDField = value;
        }
    }

    /// <comentarios/>
    public int WeaponID
    {
        get
        {
            return this.weaponIDField;
        }
        set
        {
            this.weaponIDField = value;
        }
    }

    /// <comentarios/>
    public int AmmoSpent
    {
        get
        {
            return this.ammoSpentField;
        }
        set
        {
            this.ammoSpentField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AmmoSpentSpecified
    {
        get
        {
            return this.ammoSpentFieldSpecified;
        }
        set
        {
            this.ammoSpentFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSMechs
{

    private int mechIDField;

    private bool mechIDFieldSpecified;

    private string nameField;

    private string modelField;

    private bool pilotIDFieldSpecified;

    private int walkField;

    private bool walkFieldSpecified;

    private int runField;

    private bool runFieldSpecified;

    private int heatsinksField;

    private bool heatsinksFieldSpecified;

    private decimal tonsField;

    private bool tonsFieldSpecified;

    private int jumpField;

    private bool jumpFieldSpecified;

    /// <comentarios/>
    public int MechID
    {
        get
        {
            return this.mechIDField;
        }
        set
        {
            this.mechIDField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MechIDSpecified
    {
        get
        {
            return this.mechIDFieldSpecified;
        }
        set
        {
            this.mechIDFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <comentarios/>
    public string Model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PilotIDSpecified
    {
        get
        {
            return this.pilotIDFieldSpecified;
        }
        set
        {
            this.pilotIDFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Walk
    {
        get
        {
            return this.walkField;
        }
        set
        {
            this.walkField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WalkSpecified
    {
        get
        {
            return this.walkFieldSpecified;
        }
        set
        {
            this.walkFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Run
    {
        get
        {
            return this.runField;
        }
        set
        {
            this.runField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool RunSpecified
    {
        get
        {
            return this.runFieldSpecified;
        }
        set
        {
            this.runFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Heatsinks
    {
        get
        {
            return this.heatsinksField;
        }
        set
        {
            this.heatsinksField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HeatsinksSpecified
    {
        get
        {
            return this.heatsinksFieldSpecified;
        }
        set
        {
            this.heatsinksFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public decimal Tons
    {
        get
        {
            return this.tonsField;
        }
        set
        {
            this.tonsField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TonsSpecified
    {
        get
        {
            return this.tonsFieldSpecified;
        }
        set
        {
            this.tonsFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Jump
    {
        get
        {
            return this.jumpField;
        }
        set
        {
            this.jumpField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool JumpSpecified
    {
        get
        {
            return this.jumpFieldSpecified;
        }
        set
        {
            this.jumpFieldSpecified = value;
        }
    }
}

/// <comentarios/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/DS_BTDRS.xsd")]
public partial class DS_BTDRSWeapons
{

    private int weaponIDField;

    private string nameField;

    private string damageField;

    private bool damageFieldSpecified;

    private int heatField;

    private bool heatFieldSpecified;

    private string minimumField;

    private bool minimumFieldSpecified;

    private string shortField;

    private bool shortFieldSpecified;

    private string mediumField;

    private bool mediumFieldSpecified;

    private string longField;

    private bool longFieldSpecified;

    private decimal tonsField;

    private bool tonsFieldSpecified;

    private string ammoField;

    private bool ammoFieldSpecified;

    private string WeaponTypeField;

    private bool WeaponTypeFieldSpecified;

    private int CritsField;

    private bool CritsFieldFieldSpecified;

    /// <comentarios/>
    public int WeaponID
    {
        get
        {
            return this.weaponIDField;
        }
        set
        {
            this.weaponIDField = value;
        }
    }

    /// <comentarios/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <comentarios/>
    public string Damage
    {
        get
        {
            return this.damageField;
        }
        set
        {
            this.damageField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DamageSpecified
    {
        get
        {
            return this.damageFieldSpecified;
        }
        set
        {
            this.damageFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public int Heat
    {
        get
        {
            return this.heatField;
        }
        set
        {
            this.heatField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HeatSpecified
    {
        get
        {
            return this.heatFieldSpecified;
        }
        set
        {
            this.heatFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Minimum
    {
        get
        {
            return this.minimumField;
        }
        set
        {
            this.minimumField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MinimumSpecified
    {
        get
        {
            return this.minimumFieldSpecified;
        }
        set
        {
            this.minimumFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Short
    {
        get
        {
            return this.shortField;
        }
        set
        {
            this.shortField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ShortSpecified
    {
        get
        {
            return this.shortFieldSpecified;
        }
        set
        {
            this.shortFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Medium
    {
        get
        {
            return this.mediumField;
        }
        set
        {
            this.mediumField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MediumSpecified
    {
        get
        {
            return this.mediumFieldSpecified;
        }
        set
        {
            this.mediumFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Long
    {
        get
        {
            return this.longField;
        }
        set
        {
            this.longField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LongSpecified
    {
        get
        {
            return this.longFieldSpecified;
        }
        set
        {
            this.longFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public decimal Tons
    {
        get
        {
            return this.tonsField;
        }
        set
        {
            this.tonsField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TonsSpecified
    {
        get
        {
            return this.tonsFieldSpecified;
        }
        set
        {
            this.tonsFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string Ammo
    {
        get
        {
            return this.ammoField;
        }
        set
        {
            this.ammoField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AmmoSpecified
    {
        get
        {
            return this.ammoFieldSpecified;
        }
        set
        {
            this.ammoFieldSpecified = value;
        }
    }

    /// <comentarios/>
    public string WeaponType
    {
        get
        {
            return this.WeaponTypeField;
        }
        set
        {
            this.WeaponTypeField = value;
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WeaponTypeSpecified
    {
        get
        {
            return this.WeaponTypeFieldSpecified;
        }
        set
        {
            this.WeaponTypeFieldSpecified = value;
        }
    }

    public int Crits
    {
        get
        {
            return this.CritsField;
        }
        set
        {
            this.CritsField = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CritsSpecified
    {
        get
        {
            return this.CritsFieldFieldSpecified;
        }
        set
        {
            this.CritsFieldFieldSpecified = value;
        }
    }
}
