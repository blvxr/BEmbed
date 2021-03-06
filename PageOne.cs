using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorHelper;
using Discord;
using Discord.Rest;
using Microsoft.Extensions.Configuration;

namespace BotGUI
{
    public partial class PageOne : UserControl
    {
        public DiscordRestClient discord = new DiscordRestClient();
        private List<EmbedFieldBuilder> embeds = new List<EmbedFieldBuilder>();
        private List<RestGuildChannel> channelList = new List<RestGuildChannel>();
        private IConfigurationRoot _config = new Setup().getConfig();
        public PageOne()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {

            System.Drawing.Color color = pictureBox1.BackColor;
            var builder = new EmbedBuilder()
                    .WithColor(new Discord.Color(color.R, color.G, color.B))
                    .WithCurrentTimestamp();

            foreach (var embed in embeds)
            {
                builder.AddField(embed);
            }

            if (txtAuthor.Text != "Author" && txtAuthor.Text != null)
            {
                builder.WithAuthor(txtAuthor.Text);
            }
            if (txtImage.Text != "Image URL" && txtImage.Text != null)
            {
                builder.WithImageUrl(txtImage.Text);
            }
            if (txtThumbnail.Text != "Thumbnail URL" && txtThumbnail.Text != null)
            {
                builder.WithThumbnailUrl(txtThumbnail.Text);
            }
            if (txtEmbedTitle.Text != "Embed Title" && txtEmbedTitle.Text != null)
            {
                builder.WithTitle(txtEmbedTitle.Text);
            }

            await SendEmbed(builder.Build());
        }

        private async Task SendEmbed(Embed embed)
        {
            
            await discord.LoginAsync(TokenType.Bot, _config["token"]);
            var selectedChannel = boxChannels.SelectedItem as RestGuildChannel;
            var channel = await discord.GetChannelAsync(selectedChannel.Id);
            await (channel as IRestMessageChannel).SendMessageAsync(null, false, embed);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var builder = new EmbedFieldBuilder();
            builder.WithName(txtTitle.Text).WithValue(txtContent.Text);
            embeds.Add(builder);
            ListViewItem lvItem = new ListViewItem(txtTitle.Text);
            lvItem.SubItems.Add(txtContent.Text);
            listView1.Items.Add(lvItem);
        }

        private async void PageOne_Load(object sender, EventArgs e)
        {
            await discord.LoginAsync(TokenType.Bot, _config["token"]);
            var guild = await discord.GetGuildAsync(432496922134052882);
            var channels = await guild.GetTextChannelsAsync();
            foreach (var channel in channels)
            {
                channelList.Add(channel);
                boxChannels.Items.Add(channel);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnRemoveEmbed_Click(object sender, EventArgs e)
        {
            var selectedItems = listView1.SelectedItems;
            foreach (ListViewItem item in selectedItems)
            {
                listView1.Items.RemoveAt(item.Index);
            }
        }
    }
}
