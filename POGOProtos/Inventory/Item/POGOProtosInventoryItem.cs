// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos.Inventory.Item.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory.Item {

  /// <summary>Holder for reflection information generated from POGOProtos.Inventory.Item.proto</summary>
  public static partial class POGOProtosInventoryItemReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos.Inventory.Item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static POGOProtosInventoryItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLnByb3RvEhlQT0dPUHJvdG9z",
            "LkludmVudG9yeS5JdGVtIlMKCUl0ZW1Bd2FyZBIyCgdpdGVtX2lkGAEgASgO",
            "MiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSEgoKaXRlbV9j",
            "b3VudBgCIAEoBSJdCghJdGVtRGF0YRIyCgdpdGVtX2lkGAEgASgOMiEuUE9H",
            "T1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSDQoFY291bnQYAiABKAUS",
            "DgoGdW5zZWVuGAMgASgIKrICCghJdGVtVHlwZRISCg5JVEVNX1RZUEVfTk9O",
            "RRAAEhYKEklURU1fVFlQRV9QT0tFQkFMTBABEhQKEElURU1fVFlQRV9QT1RJ",
            "T04QAhIUChBJVEVNX1RZUEVfUkVWSVZFEAMSEQoNSVRFTV9UWVBFX01BUBAE",
            "EhQKEElURU1fVFlQRV9CQVRUTEUQBRISCg5JVEVNX1RZUEVfRk9PRBAGEhQK",
            "EElURU1fVFlQRV9DQU1FUkEQBxISCg5JVEVNX1RZUEVfRElTSxAIEhcKE0lU",
            "RU1fVFlQRV9JTkNVQkFUT1IQCRIVChFJVEVNX1RZUEVfSU5DRU5TRRAKEhYK",
            "EklURU1fVFlQRV9YUF9CT09TVBALEh8KG0lURU1fVFlQRV9JTlZFTlRPUllf",
            "VVBHUkFERRAMKscFCgZJdGVtSWQSEAoMSVRFTV9VTktOT1dOEAASEgoOSVRF",
            "TV9QT0tFX0JBTEwQARITCg9JVEVNX0dSRUFUX0JBTEwQAhITCg9JVEVNX1VM",
            "VFJBX0JBTEwQAxIUChBJVEVNX01BU1RFUl9CQUxMEAQSDwoLSVRFTV9QT1RJ",
            "T04QZRIVChFJVEVNX1NVUEVSX1BPVElPThBmEhUKEUlURU1fSFlQRVJfUE9U",
            "SU9OEGcSEwoPSVRFTV9NQVhfUE9USU9OEGgSEAoLSVRFTV9SRVZJVkUQyQES",
            "FAoPSVRFTV9NQVhfUkVWSVZFEMoBEhMKDklURU1fTFVDS1lfRUdHEK0CEhoK",
            "FUlURU1fSU5DRU5TRV9PUkRJTkFSWRCRAxIXChJJVEVNX0lOQ0VOU0VfU1BJ",
            "Q1kQkgMSFgoRSVRFTV9JTkNFTlNFX0NPT0wQkwMSGAoTSVRFTV9JTkNFTlNF",
            "X0ZMT1JBTBCUAxITCg5JVEVNX1RST1lfRElTSxD1AxISCg1JVEVNX1hfQVRU",
            "QUNLENoEEhMKDklURU1fWF9ERUZFTlNFENsEEhMKDklURU1fWF9NSVJBQ0xF",
            "ENwEEhQKD0lURU1fUkFaWl9CRVJSWRC9BRIUCg9JVEVNX0JMVUtfQkVSUlkQ",
            "vgUSFQoQSVRFTV9OQU5BQl9CRVJSWRC/BRIVChBJVEVNX1dFUEFSX0JFUlJZ",
            "EMAFEhUKEElURU1fUElOQVBfQkVSUlkQwQUSGAoTSVRFTV9TUEVDSUFMX0NB",
            "TUVSQRChBhIjCh5JVEVNX0lOQ1VCQVRPUl9CQVNJQ19VTkxJTUlURUQQhQcS",
            "GQoUSVRFTV9JTkNVQkFUT1JfQkFTSUMQhgcSIQocSVRFTV9QT0tFTU9OX1NU",
            "T1JBR0VfVVBHUkFERRDpBxIeChlJVEVNX0lURU1fU1RPUkFHRV9VUEdSQURF",
            "EOoHYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Inventory.Item.ItemType), typeof(global::POGOProtos.Inventory.Item.ItemId), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.Item.ItemAward), global::POGOProtos.Inventory.Item.ItemAward.Parser, new[]{ "ItemId", "ItemCount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.Item.ItemData), global::POGOProtos.Inventory.Item.ItemData.Parser, new[]{ "ItemId", "Count", "Unseen" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ItemType {
    [pbr::OriginalName("ITEM_TYPE_NONE")] None = 0,
    [pbr::OriginalName("ITEM_TYPE_POKEBALL")] Pokeball = 1,
    [pbr::OriginalName("ITEM_TYPE_POTION")] Potion = 2,
    [pbr::OriginalName("ITEM_TYPE_REVIVE")] Revive = 3,
    [pbr::OriginalName("ITEM_TYPE_MAP")] Map = 4,
    [pbr::OriginalName("ITEM_TYPE_BATTLE")] Battle = 5,
    [pbr::OriginalName("ITEM_TYPE_FOOD")] Food = 6,
    [pbr::OriginalName("ITEM_TYPE_CAMERA")] Camera = 7,
    [pbr::OriginalName("ITEM_TYPE_DISK")] Disk = 8,
    [pbr::OriginalName("ITEM_TYPE_INCUBATOR")] Incubator = 9,
    [pbr::OriginalName("ITEM_TYPE_INCENSE")] Incense = 10,
    [pbr::OriginalName("ITEM_TYPE_XP_BOOST")] XpBoost = 11,
    [pbr::OriginalName("ITEM_TYPE_INVENTORY_UPGRADE")] InventoryUpgrade = 12,
  }

  public enum ItemId {
    [pbr::OriginalName("ITEM_UNKNOWN")] ItemUnknown = 0,
    [pbr::OriginalName("ITEM_POKE_BALL")] ItemPokeBall = 1,
    [pbr::OriginalName("ITEM_GREAT_BALL")] ItemGreatBall = 2,
    [pbr::OriginalName("ITEM_ULTRA_BALL")] ItemUltraBall = 3,
    [pbr::OriginalName("ITEM_MASTER_BALL")] ItemMasterBall = 4,
    [pbr::OriginalName("ITEM_POTION")] ItemPotion = 101,
    [pbr::OriginalName("ITEM_SUPER_POTION")] ItemSuperPotion = 102,
    [pbr::OriginalName("ITEM_HYPER_POTION")] ItemHyperPotion = 103,
    [pbr::OriginalName("ITEM_MAX_POTION")] ItemMaxPotion = 104,
    [pbr::OriginalName("ITEM_REVIVE")] ItemRevive = 201,
    [pbr::OriginalName("ITEM_MAX_REVIVE")] ItemMaxRevive = 202,
    [pbr::OriginalName("ITEM_LUCKY_EGG")] ItemLuckyEgg = 301,
    [pbr::OriginalName("ITEM_INCENSE_ORDINARY")] ItemIncenseOrdinary = 401,
    [pbr::OriginalName("ITEM_INCENSE_SPICY")] ItemIncenseSpicy = 402,
    [pbr::OriginalName("ITEM_INCENSE_COOL")] ItemIncenseCool = 403,
    [pbr::OriginalName("ITEM_INCENSE_FLORAL")] ItemIncenseFloral = 404,
    [pbr::OriginalName("ITEM_TROY_DISK")] ItemTroyDisk = 501,
    [pbr::OriginalName("ITEM_X_ATTACK")] ItemXAttack = 602,
    [pbr::OriginalName("ITEM_X_DEFENSE")] ItemXDefense = 603,
    [pbr::OriginalName("ITEM_X_MIRACLE")] ItemXMiracle = 604,
    [pbr::OriginalName("ITEM_RAZZ_BERRY")] ItemRazzBerry = 701,
    [pbr::OriginalName("ITEM_BLUK_BERRY")] ItemBlukBerry = 702,
    [pbr::OriginalName("ITEM_NANAB_BERRY")] ItemNanabBerry = 703,
    [pbr::OriginalName("ITEM_WEPAR_BERRY")] ItemWeparBerry = 704,
    [pbr::OriginalName("ITEM_PINAP_BERRY")] ItemPinapBerry = 705,
    [pbr::OriginalName("ITEM_SPECIAL_CAMERA")] ItemSpecialCamera = 801,
    [pbr::OriginalName("ITEM_INCUBATOR_BASIC_UNLIMITED")] ItemIncubatorBasicUnlimited = 901,
    [pbr::OriginalName("ITEM_INCUBATOR_BASIC")] ItemIncubatorBasic = 902,
    [pbr::OriginalName("ITEM_POKEMON_STORAGE_UPGRADE")] ItemPokemonStorageUpgrade = 1001,
    [pbr::OriginalName("ITEM_ITEM_STORAGE_UPGRADE")] ItemItemStorageUpgrade = 1002,
  }

  #endregion

  #region Messages
  public sealed partial class ItemAward : pb::IMessage<ItemAward> {
    private static readonly pb::MessageParser<ItemAward> _parser = new pb::MessageParser<ItemAward>(() => new ItemAward());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemAward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.Item.POGOProtosInventoryItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemAward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemAward(ItemAward other) : this() {
      itemId_ = other.itemId_;
      itemCount_ = other.itemCount_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemAward Clone() {
      return new ItemAward(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "item_count" field.</summary>
    public const int ItemCountFieldNumber = 2;
    private int itemCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ItemCount {
      get { return itemCount_; }
      set {
        itemCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemAward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemAward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ItemCount != other.ItemCount) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (ItemCount != 0) hash ^= ItemCount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (ItemCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ItemCount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (ItemCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemCount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemAward other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.ItemCount != 0) {
        ItemCount = other.ItemCount;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            ItemCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ItemData : pb::IMessage<ItemData> {
    private static readonly pb::MessageParser<ItemData> _parser = new pb::MessageParser<ItemData>(() => new ItemData());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.Item.POGOProtosInventoryItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemData(ItemData other) : this() {
      itemId_ = other.itemId_;
      count_ = other.count_;
      unseen_ = other.unseen_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemData Clone() {
      return new ItemData(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId itemId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 2;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "unseen" field.</summary>
    public const int UnseenFieldNumber = 3;
    private bool unseen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Unseen {
      get { return unseen_; }
      set {
        unseen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Count != other.Count) return false;
      if (Unseen != other.Unseen) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (Unseen != false) hash ^= Unseen.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemId);
      }
      if (Count != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Count);
      }
      if (Unseen != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unseen);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemId);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (Unseen != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemData other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.Unseen != false) {
        Unseen = other.Unseen;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            itemId_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            Count = input.ReadInt32();
            break;
          }
          case 24: {
            Unseen = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
