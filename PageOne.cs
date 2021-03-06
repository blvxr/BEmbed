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

namespace BotGUI
{
    public partial class PageOne : UserControl
    {

        private List<EmbedFieldBuilder> embeds = new List<EmbedFieldBuilder>();

        public PageOne()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {

            System.Drawing.Color color = pictureBox1.BackColor;
            var builder = new EmbedBuilder()
                    .WithColor(new Discord.Color(color.R, color.G, color.B))
                    .WithAuthor(txtAuthor.Text)
                    .WithTitle(txtEmbedTitle.Text)
                    .WithCurrentTimestamp();

            foreach (var embed in embeds)
            {
                builder.AddField(embed);
            }

            await SendEmbed(builder.Build());
        }

        private async Task SendEmbed(Embed embed)
        {
            DiscordRestClient discord = new DiscordRestClient();
            await discord.LoginAsync(TokenType.Bot, txtToken.Text);
            var channel = await discord.GetChannelAsync(644068713921773579);
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

        private void PageOne_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
