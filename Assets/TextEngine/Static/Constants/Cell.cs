namespace Assets.TextEngine.Static.Constants
{
    public class Cell
    {
        public const string OptionFormatting = "<b><color=lime><size=25>{0}</size></color></b>";

        public static string cellText = string.Concat("You are in a prison cell, and you want to escape. There are ",
            "some dirty sheets on the bed, a mirror on the wall, and the door is locked from the outside.\n\n",
            "Press ", string.Format(OptionFormatting, "S"), " to view Sheets.\n\nPress ", string.Format(OptionFormatting, "M"),
            " to view Mirror.\n\nPress ", string.Format(OptionFormatting, "L"), " to view Lock.");

        public static string sheets0Text = string.Concat("You can't believe you sleep in these things. Surely it's time somebody ",
            "changed them. The pleasures of prison life I guess!!\n\n",
            "Press ", string.Format(OptionFormatting, "R"), " to Return to roaming your cell.");

        public static string sheets1Text = string.Concat("Holding a mirror in your hand doesn't make the sheets look any better.\n\n",
            "Press ", string.Format(OptionFormatting, "R"), " to Return to roaming your cell.");

        public static string lock0Text = string.Concat("This is one of those button locks. You have no idea what the combination is. You",
            "wish you could somehow see where the dirty fingerprints were, maybe that would help.\n\n",
            "Press ", string.Format(OptionFormatting, "R"), " to Return to roaming your cell.");

        public static string lock1Text = string.Concat("You carefully put the mirror through the bars, and turn it round so you can see the ",
            "lock. You can just make out fingerprints around the buttons. You press the dirty buttons, and hear a click.\n\n",
            "Press ", string.Format(OptionFormatting, "O"), " to Open.\n\nPress ", string.Format(OptionFormatting, "R"), " to ",
            "Return to your cell.");

        public static string cellMirrorText = string.Concat("You are still in your cell, and you STILL want to escape! There are some dirty sheets on the bed, ",
            " a mark where the mirror used to be, and that pesky door is still firmly locked!\n\nPress ", string.Format(OptionFormatting, "S"),
            " to view Sheets.\n\nPress ", string.Format(OptionFormatting, "L"), " to view Lock.");

        public static string mirrorText = string.Concat("The dirty old mirror on the wall seems loose.\n\nPress ", string.Format(OptionFormatting, "T"),
            " to Take the mirror.\n\nPress ", string.Format(OptionFormatting, "R"), " to Return to roaming your cell.");

        public static string freedomText = string.Concat("You are FREE!\n\nPress ", string.Format(OptionFormatting, "P"), " to Play again.");
    }
}
