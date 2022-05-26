
using Newtonsoft.Json;
using System.Drawing;

namespace _4RTools.Model
{

    public sealed class Menu {
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#5b3715");
        public Color ButtonsBackgroundColor { get; set; } = ColorTranslator.FromHtml("#efb561");
        public Color ButtonsForegroundColor { get; set; } = ColorTranslator.FromHtml("#5b3715");
        public Color ButtonActiveHighlightColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        public Color LabelVersionColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
    }

    public sealed class Header {
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        public Color CharacterNameColor { get; set; } = ColorTranslator.FromHtml("#047d36");
        public Color ModuleNameColor { get; set; } = ColorTranslator.FromHtml("#5b3715");
    }

    public sealed class InternalPanels
    {
        public Color BackgroundColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#5b3715");
    }

    internal class Footer { }
    public sealed class Controls {

        //Start ========= TEXT INPUT
        public Color TextInputBackColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        public Color TextInputForeColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        public Color TextInputBorderColor { get; set; } = ColorTranslator.FromHtml("#5b3715");
        public Color TextInputFocusBorderColor { get; set; } = ColorTranslator.FromHtml("#fcdcca");
        //End ========= TEXT INPUT

        //Start ========== Checkbox

        //End ========== Checkbox
    }


    public class Theme : Action
    {
        public Menu Menu { get; set; } = new Menu();
        public Header Header { get; set; } = new Header();
        public InternalPanels Panels { get; set; } = new InternalPanels();
        public Controls Controls { get; set; } = new Controls();

        private string ACTION_NAME = "Theme";

        public string GetActionName()
        {
            return ACTION_NAME;
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void Persist(){ }

        public void Start(){ }

        public void Stop() { }
    }
}
