using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;

//namespace NppPluginNET.PluginInfrastructure
//{
    public static class Util
    {
        public static int FindNext(string  searchText, IScintillaGateway editor)
        {
            editor.SetSearchFlags(FindOption.NONE);
            editor.SetTargetStart(Math.Max(editor.GetCurrentPos(), editor.GetAnchor()));
            editor.SetTargetEnd(editor.GetTextLength());

            int pos = editor.SearchInTarget(searchText.Length, searchText);
            if (pos >= 0)
            {
                editor.SetSel(editor.GetTargetStart(), editor.GetTargetEnd());
            }

            return pos;
        }

        public static int ReplaceNext(string searchText, string replaceText, IScintillaGateway editor)
        {
            // Find the text and, if found, replace the selection
            var pos = FindNext(searchText, editor);
            if (pos >= 0)
                editor.ReplaceSel(replaceText);
            return pos;
        }

        public static void ReplaceAll(string searchText, string replaceText, IScintillaGateway editor)
        {
            var pos = 0;
            editor.GotoLine(0);
            editor.SetTargetStart(0);
            // Iterate until text is no longer found
            while (pos >= 0)
            {
                pos = ReplaceNext(searchText, replaceText, editor);
            }
        }



}



//}
