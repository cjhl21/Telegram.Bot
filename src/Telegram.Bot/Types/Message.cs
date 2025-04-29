// GENERATED FILE - DO NOT MODIFY MANUALLY
namespace Telegram.Bot.Types;

/// <summary>This object represents a message.</summary>
public partial class Message
{
    /// <summary>这个聊天中的唯一消息标识符。在特定的情况下（例如，包含视频的消息要发送给一个大型聊天），服务器可能会自动调度消息，而不是立即发送。在这种情况下，该字段将为0，相关的消息在实际发送之前将不可用 Unique message identifier inside this chat. In specific instances (e.g., message containing a video sent to a big chat), the server might automatically schedule a message instead of sending it immediately. In such cases, this field will be 0 and the relevant message will be unusable until it is actually sent</summary>
    [JsonPropertyName("message_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int Id { get; set; }

    /// <summary><em>Optional</em>. 该消息所属的消息线程的唯一标识符；仅对超群有效 Unique identifier of a message thread to which the message belongs; for supergroups only</summary>
    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    /// <summary><em>Optional</em>. 信息发送者；对于发送到通道的消息，可能为空。为了向后兼容，如果消息是代表聊天发送的，则该字段包含非频道聊天中的假发送者用户 Sender of the message; may be empty for messages sent to channels. For backward compatibility, if the message was sent on behalf of a chat, the field contains a fake sender user in non-channel chats</summary>
    public User? From { get; set; }

    /// <summary><em>Optional</em>. 发送者代表聊天发送消息。例如，超级组本身用于匿名管理员发送的消息，或者链接通道用于自动转发到通道的讨论组的消息。为了向后兼容，如果消息是代表聊天发送的，<see cref="From">From</see>字段包含非频道聊天中的假发送者用户 Sender of the message when sent on behalf of a chat. For example, the supergroup itself for messages sent by its anonymous administrators or a linked channel for messages automatically forwarded to the channel's discussion group. For backward compatibility, if the message was sent on behalf of a chat, the field <see cref="From">From</see> contains a fake sender user in non-channel chats.</summary>
    [JsonPropertyName("sender_chat")]
    public Chat? SenderChat { get; set; }

    /// <summary><em>Optional</em>.如果消息的发送者增加了聊天次数，则增加的次数由用户增加  If the sender of the message boosted the chat, the number of boosts added by the user</summary>
    [JsonPropertyName("sender_boost_count")]
    public int? SenderBoostCount { get; set; }

    /// <summary><em>Optional</em>. 代表业务帐户实际发送消息的机器人。只适用于代表相关业务帐户发送的外发邮件 The bot that actually sent the message on behalf of the business account. Available only for outgoing messages sent on behalf of the connected business account.</summary>
    [JsonPropertyName("sender_business_bot")]
    public User? SenderBusinessBot { get; set; }

    /// <summary>Date the message was sent. It is always a valid date.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Date { get; set; }

    /// <summary><em>Optional</em>. 接收消息的业务连接的唯一标识符。如果非空，则消息属于对应业务帐户的聊天，该聊天独立于任何可能共享相同标识符的潜在聊天机器人 Unique identifier of the business connection from which the message was received. If non-empty, the message belongs to a chat of the corresponding business account that is independent from any potential bot chat which might share the same identifier.</summary>
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    /// <summary>Chat the message belongs to</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public Chat Chat { get; set; } = default!;

    /// <summary><em>Optional</em>. 转发消息的原始消息信息 Information about the original message for forwarded messages</summary>
    [JsonPropertyName("forward_origin")]
    public MessageOrigin? ForwardOrigin { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, if the message is sent to a forum topic</summary>
    [JsonPropertyName("is_topic_message")]
    public bool IsTopicMessage { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, 如果消息是自动转发到连接的讨论组的频道帖子 if the message is a channel post that was automatically forwarded to the connected discussion group</summary>
    [JsonPropertyName("is_automatic_forward")]
    public bool IsAutomaticForward { get; set; }

    /// <summary><em>Optional</em>. 对于回复在同一聊天和消息线程，原始消息。请注意，这个字段中的Message对象不会包含其他字段ReplyToMessage，即使它本身是一个回复 For replies in the same chat and message thread, the original message. Note that the Message object in this field will not contain further <see cref="ReplyToMessage">ReplyToMessage</see> fields even if it itself is a reply.</summary>
    [JsonPropertyName("reply_to_message")]
    public Message? ReplyToMessage { get; set; }

    /// <summary><em>Optional</em>. 正在回复的消息的相关信息，可能来自另一个聊天或论坛主题 Information about the message that is being replied to, which may come from another chat or forum topic</summary>
    [JsonPropertyName("external_reply")]
    public ExternalReplyInfo? ExternalReply { get; set; }

    /// <summary><em>Optional</em>. 对于引用原始消息部分的回复，则引用消息的部分 For replies that quote part of the original message, the quoted part of the message</summary>
    public TextQuote? Quote { get; set; }

    /// <summary><em>Optional</em>. 对于一个故事的回复，原始的故事 For replies to a story, the original story</summary>
    [JsonPropertyName("reply_to_story")]
    public Story? ReplyToStory { get; set; }

    /// <summary><em>Optional</em>. 通过机器人发送消息 Bot through which the message was sent</summary>
    [JsonPropertyName("via_bot")]
    public User? ViaBot { get; set; }

    /// <summary><em>Optional</em>. 消息最后编辑的日期 Date the message was last edited</summary>
    [JsonPropertyName("edit_date")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? EditDate { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>,如果消息不能转发 if the message can't be forwarded</summary>
    [JsonPropertyName("has_protected_content")]
    public bool HasProtectedContent { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, 如果消息是通过隐式操作发送的，例如，作为发送的业务消息或问候消息，或作为预定的消息 if the message was sent by an implicit action, for example, as an away or a greeting business message, or as a scheduled message</summary>
    [JsonPropertyName("is_from_offline")]
    public bool IsFromOffline { get; set; }

    /// <summary><em>Optional</em>.此消息所属的媒体消息组的唯一标识符  The unique identifier of a media message group this message belongs to</summary>
    [JsonPropertyName("media_group_id")]
    public string? MediaGroupId { get; set; }

    /// <summary><em>Optional</em>. 通道中消息的post作者签名，或匿名组管理员的自定义标题 Signature of the post author for messages in channels, or the custom title of an anonymous group administrator</summary>
    [JsonPropertyName("author_signature")]
    public string? AuthorSignature { get; set; }

    /// <summary><em>Optional</em>. 对于文本消息，表示消息的实际文本 For text messages, the actual text of the message</summary>
    public string? Text { get; set; }

    /// <summary><em>Optional</em>. 对于文本消息，文本中出现的特殊实体，如用户名、url、机器人命令等 For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text</summary>
    public MessageEntity[]? Entities { get; set; }

    /// <summary><em>Optional</em>. 用于生成消息链接预览的选项，如果它是文本消息，则更改了链接预览选项 Options used for link preview generation for the message, if it is a text message and link preview options were changed</summary>
    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptions? LinkPreviewOptions { get; set; }

    /// <summary><em>Optional</em>. 添加到消息中的消息效果的唯一标识符 Unique identifier of the message effect added to the message</summary>
    [JsonPropertyName("effect_id")]
    public string? EffectId { get; set; }

    /// <summary><em>Optional</em>. Message是一个动画，是关于动画的信息。为了向后兼容，当设置此字段时 Message is an animation, information about the animation. For backward compatibility, when this field is set, the <see cref="Document">Document</see> field will also be set</summary>
    public Animation? Animation { get; set; }

    /// <summary><em>Optional</em>. Message is an audio file, information about the file</summary>
    public Audio? Audio { get; set; }

    /// <summary><em>Optional</em>. Message is a general file, information about the file</summary>
    public Document? Document { get; set; }

    /// <summary><em>Optional</em>. 付费 Message contains paid media; information about the paid media</summary>
    [JsonPropertyName("paid_media")]
    public PaidMediaInfo? PaidMedia { get; set; }

    /// <summary><em>Optional</em>. Message is a photo, available sizes of the photo</summary>
    public PhotoSize[]? Photo { get; set; }

    /// <summary><em>Optional</em>. 贴纸 Message is a sticker, information about the sticker</summary>
    public Sticker? Sticker { get; set; }

    /// <summary><em>Optional</em>. 消息是一个被转发的故事 Message is a forwarded story</summary>
    public Story? Story { get; set; }

    /// <summary><em>Optional</em>. Message is a video, information about the video</summary>
    public Video? Video { get; set; }

    /// <summary><em>Optional</em>. Message is a <a href="https://telegram.org/blog/video-messages-and-telescope">video note</a>, information about the video message</summary>
    [JsonPropertyName("video_note")]
    public VideoNote? VideoNote { get; set; }

    /// <summary><em>Optional</em>. Message is a voice message, information about the file</summary>
    public Voice? Voice { get; set; }

    /// <summary><em>Optional</em>. 动画、音频、文档、付费媒体、照片、视频或声音的说明 Caption for the animation, audio, document, paid media, photo, video or voice</summary>
    public string? Caption { get; set; }

    /// <summary><em>Optional</em>. 对于带有标题的消息，在标题中出现的特殊实体，如用户名、url、机器人命令等 For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption</summary>
    [JsonPropertyName("caption_entities")]
    public MessageEntity[]? CaptionEntities { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, 如果标题必须显示在消息媒体之上 if the caption must be shown above the message media</summary>
    [JsonPropertyName("show_caption_above_media")]
    public bool ShowCaptionAboveMedia { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, 如果消息媒体被剧透动画覆盖 if the message media is covered by a spoiler animation</summary>
    [JsonPropertyName("has_media_spoiler")]
    public bool HasMediaSpoiler { get; set; }

    /// <summary><em>Optional</em>. 消息是一个共享的联系人，该联系人的信息 Message is a shared contact, information about the contact</summary>
    public Contact? Contact { get; set; }

    /// <summary><em>Optional</em>. Message是一个具有随机值的骰子 Message is a dice with random value</summary>
    public Dice? Dice { get; set; }

    /// <summary><em>Optional</em>. Message is a game, information about the game. <a href="https://core.telegram.org/bots/api#games">More about games »</a></summary>
    public Game? Game { get; set; }

    /// <summary><em>Optional</em>. Message is a native poll, information about the poll</summary>
    public Poll? Poll { get; set; }

    /// <summary><em>Optional</em>. 聚会地点 Message is a venue, information about the venue. For backward compatibility, when this field is set, the <see cref="Location">Location</see> field will also be set</summary>
    public Venue? Venue { get; set; }

    /// <summary><em>Optional</em>. Message is a shared location, information about the location</summary>
    public Location? Location { get; set; }

    /// <summary><em>Optional</em>. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)</summary>
    [JsonPropertyName("new_chat_members")]
    public User[]? NewChatMembers { get; set; }

    /// <summary><em>Optional</em>. A member was removed from the group, information about them (this member may be the bot itself)</summary>
    [JsonPropertyName("left_chat_member")]
    public User? LeftChatMember { get; set; }

    /// <summary><em>Optional</em>. A chat title was changed to this value</summary>
    [JsonPropertyName("new_chat_title")]
    public string? NewChatTitle { get; set; }

    /// <summary><em>Optional</em>. A chat photo was change to this value</summary>
    [JsonPropertyName("new_chat_photo")]
    public PhotoSize[]? NewChatPhoto { get; set; }

    /// <summary><em>Optional</em>. Service message: the chat photo was deleted</summary>
    [JsonPropertyName("delete_chat_photo")]
    public bool? DeleteChatPhoto { get; set; }

    /// <summary><em>Optional</em>. Service message: the group has been created</summary>
    [JsonPropertyName("group_chat_created")]
    public bool? GroupChatCreated { get; set; }

    /// <summary><em>Optional</em>. Service message: the supergroup has been created. This field can't be received in a message coming through updates, because bot can't be a member of a supergroup when it is created. It can only be found in <see cref="ReplyToMessage">ReplyToMessage</see> if someone replies to a very first message in a directly created supergroup.</summary>
    [JsonPropertyName("supergroup_chat_created")]
    public bool? SupergroupChatCreated { get; set; }

    /// <summary><em>Optional</em>. Service message: the channel has been created. This field can't be received in a message coming through updates, because bot can't be a member of a channel when it is created. It can only be found in <see cref="ReplyToMessage">ReplyToMessage</see> if someone replies to a very first message in a channel.</summary>
    [JsonPropertyName("channel_chat_created")]
    public bool? ChannelChatCreated { get; set; }

    /// <summary><em>Optional</em>. 服务消息：自动删除聊天中更改的定时器设置 Service message: auto-delete timer settings changed in the chat</summary>
    [JsonPropertyName("message_auto_delete_timer_changed")]
    public MessageAutoDeleteTimerChanged? MessageAutoDeleteTimerChanged { get; set; }

    /// <summary><em>Optional</em>. 该组已经迁移到具有指定标识符的超级组。 The group has been migrated to a supergroup with the specified identifier.</summary>
    [JsonPropertyName("migrate_to_chat_id")]
    public long? MigrateToChatId { get; set; }

    /// <summary><em>Optional</em>. 超级组已经从具有指定标识符的组迁移 The supergroup has been migrated from a group with the specified identifier.</summary>
    [JsonPropertyName("migrate_from_chat_id")]
    public long? MigrateFromChatId { get; set; }

    /// <summary><em>Optional</em>. 指定消息固定。注意，这个字段中的Message对象不会再包含<see cref="ReplyToMessage">ReplyToMessage</see>字段，即使它本身是一个回复  Specified message was pinned. Note that the Message object in this field will not contain further <see cref="ReplyToMessage">ReplyToMessage</see> fields even if it itself is a reply.</summary>
    [JsonPropertyName("pinned_message")]
    public Message? PinnedMessage { get; set; }

    /// <summary><em>Optional</em>. 发票 Message is an invoice for a <a href="https://core.telegram.org/bots/api#payments">payment</a>, information about the invoice. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a></summary>
    public Invoice? Invoice { get; set; }

    /// <summary><em>Optional</em>. Message是关于成功付款的服务消息，关于付款的信息 Message is a service message about a successful payment, information about the payment. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a></summary>
    [JsonPropertyName("successful_payment")]
    public SuccessfulPayment? SuccessfulPayment { get; set; }

    /// <summary><em>Optional</em>. Message是关于退款的服务消息，关于付款的信息 Message is a service message about a refunded payment, information about the payment. <a href="https://core.telegram.org/bots/api#payments">More about payments »</a></summary>
    [JsonPropertyName("refunded_payment")]
    public RefundedPayment? RefundedPayment { get; set; }

    /// <summary><em>Optional</em>. 服务消息：用户与机器人共享 Service message: users were shared with the bot</summary>
    [JsonPropertyName("users_shared")]
    public UsersShared? UsersShared { get; set; }

    /// <summary><em>Optional</em>. 服务消息：与机器人共享聊天 Service message: a chat was shared with the bot</summary>
    [JsonPropertyName("chat_shared")]
    public ChatShared? ChatShared { get; set; }

    /// <summary><em>Optional</em>. 用户登录的网站域名。 The domain name of the website on which the user has logged in. <a href="https://core.telegram.org/widgets/login">More about Telegram Login »</a></summary>
    [JsonPropertyName("connected_website")]
    public string? ConnectedWebsite { get; set; }

    /// <summary><em>Optional</em>. 服务消息：用户允许机器人在将其添加到附件或侧菜单后编写消息，从链接启动Web应用程序，或从该方法发送的Web应用程序接收显式请求 Service message: the user allowed the bot to write messages after adding it to the attachment or side menu, launching a Web App from a link, or accepting an explicit request from a Web App sent by the method <a href="https://core.telegram.org/bots/webapps#initializing-mini-apps">requestWriteAccess</a></summary>
    [JsonPropertyName("write_access_allowed")]
    public WriteAccessAllowed? WriteAccessAllowed { get; set; }

    /// <summary><em>Optional</em>. 电报护照资料 Telegram Passport data</summary>
    [JsonPropertyName("passport_data")]
    public PassportData? PassportData { get; set; }

    /// <summary><em>Optional</em>. 服务消息。聊天中的一个用户在分享实时位置时触发了另一个用户的邻近提醒 Service message. A user in the chat triggered another user's proximity alert while sharing Live Location.</summary>
    [JsonPropertyName("proximity_alert_triggered")]
    public ProximityAlertTriggered? ProximityAlertTriggered { get; set; }

    /// <summary><em>Optional</em>. 服务消息：用户增加聊天次数 Service message: user boosted the chat</summary>
    [JsonPropertyName("boost_added")]
    public ChatBoostAdded? BoostAdded { get; set; }

    /// <summary><em>Optional</em>. 服务消息：聊天后台设置 Service message: chat background set</summary>
    [JsonPropertyName("chat_background_set")]
    public ChatBackground? ChatBackgroundSet { get; set; }

    /// <summary><em>Optional</em>. 服务消息：已创建论坛主题 Service message: forum topic created</summary>
    [JsonPropertyName("forum_topic_created")]
    public ForumTopicCreated? ForumTopicCreated { get; set; }

    /// <summary><em>Optional</em>. 服务信息：论坛主题编辑 Service message: forum topic edited</summary>
    [JsonPropertyName("forum_topic_edited")]
    public ForumTopicEdited? ForumTopicEdited { get; set; }

    /// <summary><em>Optional</em>. Service message: forum topic closed</summary>
    [JsonPropertyName("forum_topic_closed")]
    public ForumTopicClosed? ForumTopicClosed { get; set; }

    /// <summary><em>Optional</em>. Service message: forum topic reopened</summary>
    [JsonPropertyName("forum_topic_reopened")]
    public ForumTopicReopened? ForumTopicReopened { get; set; }

    /// <summary><em>Optional</em>. 服务消息：隐藏“一般”论坛主题 Service message: the 'General' forum topic hidden</summary>
    [JsonPropertyName("general_forum_topic_hidden")]
    public GeneralForumTopicHidden? GeneralForumTopicHidden { get; set; }

    /// <summary><em>Optional</em>. Service message: the 'General' forum topic unhidden</summary>
    [JsonPropertyName("general_forum_topic_unhidden")]
    public GeneralForumTopicUnhidden? GeneralForumTopicUnhidden { get; set; }

    /// <summary><em>Optional</em>. 服务消息：创建了一个预定的赠品 Service message: a scheduled giveaway was created</summary>
    [JsonPropertyName("giveaway_created")]
    public GiveawayCreated? GiveawayCreated { get; set; }

    /// <summary><em>Optional</em>. 该消息是预定的泄露消息 The message is a scheduled giveaway message</summary>
    public Giveaway? Giveaway { get; set; }

    /// <summary><em>Optional</em>. 公开赢家的赠品完成了 A giveaway with public winners was completed</summary>
    [JsonPropertyName("giveaway_winners")]
    public GiveawayWinners? GiveawayWinners { get; set; }

    /// <summary><em>Optional</em>. Service message: 一个没有公开赢家的赠品完成了 a giveaway without public winners was completed</summary>
    [JsonPropertyName("giveaway_completed")]
    public GiveawayCompleted? GiveawayCompleted { get; set; }

    /// <summary><em>Optional</em>. Service message: 预约视频聊天 video chat scheduled</summary>
    [JsonPropertyName("video_chat_scheduled")]
    public VideoChatScheduled? VideoChatScheduled { get; set; }

    /// <summary><em>Optional</em>. Service message: video chat started</summary>
    [JsonPropertyName("video_chat_started")]
    public VideoChatStarted? VideoChatStarted { get; set; }

    /// <summary><em>Optional</em>. Service message: video chat ended</summary>
    [JsonPropertyName("video_chat_ended")]
    public VideoChatEnded? VideoChatEnded { get; set; }

    /// <summary><em>Optional</em>. Service message: 新参与者被邀请进行视频聊天 new participants invited to a video chat</summary>
    [JsonPropertyName("video_chat_participants_invited")]
    public VideoChatParticipantsInvited? VideoChatParticipantsInvited { get; set; }

    /// <summary><em>Optional</em>. Service message: data sent by a Web App</summary>
    [JsonPropertyName("web_app_data")]
    public WebAppData? WebAppData { get; set; }

    /// <summary><em>Optional</em>. Inline keyboard attached to the message. <c>LoginUrl</c> buttons are represented as ordinary <c>url</c> buttons.</summary>
    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>Gets the <see cref="MessageType">type</see> of the <see cref="Message"/></summary>
    /// <value>The <see cref="MessageType">type</see> of the <see cref="Message"/></value>
    [JsonIgnore]
    public MessageType Type => this switch
    {
        { Text: not null }                              => MessageType.Text,
        { Animation: not null }                         => MessageType.Animation,
        { Audio: not null }                             => MessageType.Audio,
        { Document: not null }                          => MessageType.Document,
        { PaidMedia: not null }                         => MessageType.PaidMedia,
        { Photo: not null }                             => MessageType.Photo,
        { Sticker: not null }                           => MessageType.Sticker,
        { Story: not null }                             => MessageType.Story,
        { Video: not null }                             => MessageType.Video,
        { VideoNote: not null }                         => MessageType.VideoNote,
        { Voice: not null }                             => MessageType.Voice,
        { Contact: not null }                           => MessageType.Contact,
        { Dice: not null }                              => MessageType.Dice,
        { Game: not null }                              => MessageType.Game,
        { Poll: not null }                              => MessageType.Poll,
        { Venue: not null }                             => MessageType.Venue,
        { Location: not null }                          => MessageType.Location,
        { NewChatMembers: not null }                    => MessageType.NewChatMembers,
        { LeftChatMember: not null }                    => MessageType.LeftChatMember,
        { NewChatTitle: not null }                      => MessageType.NewChatTitle,
        { NewChatPhoto: not null }                      => MessageType.NewChatPhoto,
        { DeleteChatPhoto: not null }                   => MessageType.DeleteChatPhoto,
        { GroupChatCreated: not null }                  => MessageType.GroupChatCreated,
        { SupergroupChatCreated: not null }             => MessageType.SupergroupChatCreated,
        { ChannelChatCreated: not null }                => MessageType.ChannelChatCreated,
        { MessageAutoDeleteTimerChanged: not null }     => MessageType.MessageAutoDeleteTimerChanged,
        { MigrateToChatId: not null }                   => MessageType.MigrateToChatId,
        { MigrateFromChatId: not null }                 => MessageType.MigrateFromChatId,
        { PinnedMessage: not null }                     => MessageType.PinnedMessage,
        { Invoice: not null }                           => MessageType.Invoice,
        { SuccessfulPayment: not null }                 => MessageType.SuccessfulPayment,
        { RefundedPayment: not null }                   => MessageType.RefundedPayment,
        { UsersShared: not null }                       => MessageType.UsersShared,
        { ChatShared: not null }                        => MessageType.ChatShared,
        { ConnectedWebsite: not null }                  => MessageType.ConnectedWebsite,
        { WriteAccessAllowed: not null }                => MessageType.WriteAccessAllowed,
        { PassportData: not null }                      => MessageType.PassportData,
        { ProximityAlertTriggered: not null }           => MessageType.ProximityAlertTriggered,
        { BoostAdded: not null }                        => MessageType.BoostAdded,
        { ChatBackgroundSet: not null }                 => MessageType.ChatBackgroundSet,
        { ForumTopicCreated: not null }                 => MessageType.ForumTopicCreated,
        { ForumTopicEdited: not null }                  => MessageType.ForumTopicEdited,
        { ForumTopicClosed: not null }                  => MessageType.ForumTopicClosed,
        { ForumTopicReopened: not null }                => MessageType.ForumTopicReopened,
        { GeneralForumTopicHidden: not null }           => MessageType.GeneralForumTopicHidden,
        { GeneralForumTopicUnhidden: not null }         => MessageType.GeneralForumTopicUnhidden,
        { GiveawayCreated: not null }                   => MessageType.GiveawayCreated,
        { Giveaway: not null }                          => MessageType.Giveaway,
        { GiveawayWinners: not null }                   => MessageType.GiveawayWinners,
        { GiveawayCompleted: not null }                 => MessageType.GiveawayCompleted,
        { VideoChatScheduled: not null }                => MessageType.VideoChatScheduled,
        { VideoChatStarted: not null }                  => MessageType.VideoChatStarted,
        { VideoChatEnded: not null }                    => MessageType.VideoChatEnded,
        { VideoChatParticipantsInvited: not null }      => MessageType.VideoChatParticipantsInvited,
        { WebAppData: not null }                        => MessageType.WebAppData,
        _                                               => MessageType.Unknown
    };
}
