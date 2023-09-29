﻿using System.Runtime.CompilerServices;
using MementoMori.Ortega.Share.Data.Item;
using MessagePack;

namespace MementoMori.Ortega.Share.Data.ApiInterface.GuildRaid
{
	[MessagePackObject(true)]
	public class GiveGuildRaidWorldRewardItemResponse : ApiResponseBase, IUserSyncApiResponse
	{
		public List<UserItem> RewardItems{ get; set; }

		public UserSyncData UserSyncData{ get; set; }
	}
}
