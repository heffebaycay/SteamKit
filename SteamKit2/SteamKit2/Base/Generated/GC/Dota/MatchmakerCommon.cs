//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: matchmaker_common.proto
namespace SteamKit2.GC.Dota.Internal
{
    [global::ProtoBuf.ProtoContract(Name=@"MatchType", EnumPassthru=true)]
    public enum MatchType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_TYPE_RANKED", Value=0)]
      MATCH_TYPE_RANKED = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_TYPE_COOP_BOTS", Value=1)]
      MATCH_TYPE_COOP_BOTS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_TYPE_TEAM_RANKED", Value=2)]
      MATCH_TYPE_TEAM_RANKED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_TYPE_SOLO_QUEUE", Value=3)]
      MATCH_TYPE_SOLO_QUEUE = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"DOTABotDifficulty", EnumPassthru=true)]
    public enum DOTABotDifficulty
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_PASSIVE", Value=0)]
      BOT_DIFFICULTY_PASSIVE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_EASY", Value=1)]
      BOT_DIFFICULTY_EASY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_MEDIUM", Value=2)]
      BOT_DIFFICULTY_MEDIUM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_HARD", Value=3)]
      BOT_DIFFICULTY_HARD = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_UNFAIR", Value=4)]
      BOT_DIFFICULTY_UNFAIR = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOT_DIFFICULTY_INVALID", Value=5)]
      BOT_DIFFICULTY_INVALID = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"MatchLanguages", EnumPassthru=true)]
    public enum MatchLanguages
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_ENGLISH", Value=1)]
      MATCH_LANGUAGE_ENGLISH = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_RUSSIAN", Value=2)]
      MATCH_LANGUAGE_RUSSIAN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_CHINESE", Value=3)]
      MATCH_LANGUAGE_CHINESE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_KOREAN", Value=4)]
      MATCH_LANGUAGE_KOREAN = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_SPANISH", Value=5)]
      MATCH_LANGUAGE_SPANISH = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATCH_LANGUAGE_PORTUGUESE", Value=6)]
      MATCH_LANGUAGE_PORTUGUESE = 6
    }
  
}
#pragma warning restore 1591
