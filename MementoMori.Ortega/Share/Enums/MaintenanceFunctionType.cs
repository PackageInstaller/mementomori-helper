﻿using System.ComponentModel;

namespace MementoMori.Ortega.Share.Enums;

[Description("機能メインテナンス種別")]
public enum MaintenanceFunctionType
{
    [Description("なし")] None,
    [Description("プレゼントボックス")] PresentBox,
    [Description("ミッション")] Mission,
    [Description("ミッション-ウィークリー")] MissionWeekly,
    [Description("ミッション-メイン")] MissionMain,
    [Description("図鑑")] CharacterBook,
    [Description("キャラ所持枠購入")] ExpansionCharacterBox,
    [Description("アイテム画面-スフィア")] SphereInItemBox,
    [Description("アイテム画面-パーツ")] PartsInItemBox,
    [Description("アイテム画面-その他")] EtcInItemBox,
    [Description("試練一覧画面")] TrialRoom,
    [Description("バトルリーグ")] BattleLeague,
    [Description("レジェンドリーグ")] LegendLeague,
    [Description("祈りの泉")] BountyQuest,
    [Description("幻影の神殿")] LocalRaid,
    [Description("時空の洞窟")] DungeonBattle,
    [Description("無窮の塔")] TowerBattle,
    [Description("ガチャ画面")] GachaRoom,
    [Description("チャットボタン")] ChatButton,
    [Description("チャット画面-SVS用")] SvsInChatRoom,
    [Description("チャット画面-ギルド")] GuildInChatRoom,
    [Description("チャット画面-個人")] PrivateInChatRoom,
    [Description("ギルド画面")] Guild,
    [Description("ギルドバトル")] GuildBattle,
    [Description("グランドバトル")] GrandBattle,
    [Description("ギルドレイド")] GuildRaid,
    [Description("ランキング")] Ranking,
    [Description("メモリー")] CharacterCollection,
    [Description("ロイヤルショップ")] RoyalShop,
    [Description("ショップ（交換所）")] TradeShop,
    [Description("アイテム消費-キャラ抽選宝箱")] CharacterGachaBoxItem,
    [Description("新規ユーザー")] NewUser,
    [Description("ギルドツリー")] GuildTower,
    [Description("チャット画面-ブロック")] BlockInChatRoom,
    [Description("ギルドツリー-ランキング画面")] GuildTowerRanking,
    [Description("ギルドバトルMVP")] GuildBattleMvp,
    [Description("グランドバトルMVP")] GrandBattleMvp,
    [Description("人気投票")] PopularityVote
}