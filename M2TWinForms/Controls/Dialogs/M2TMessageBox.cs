using M2TWinForms.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace M2TWinForms
{
    public class M2TMessageBox
    {
        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(
            string? text,
            string? caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            return ShowCore(null, text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(
            string? text,
            string? caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return ShowCore(null, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(string? text, string? caption, MessageBoxButtons buttons)
        {
            return ShowCore(null, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text and caption.
        /// </summary>
        public static DialogResult Show(string? text, string? caption)
        {
            return ShowCore(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text.
        /// </summary>
        public static DialogResult Show(string? text)
        {
            return ShowCore(null, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(
            IWin32Window? owner,
            string? text,
            string? caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            return ShowCore(owner, text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(
            IWin32Window? owner,
            string? text,
            string? caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return ShowCore(owner, text, caption, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text, caption, and style.
        /// </summary>
        public static DialogResult Show(
            IWin32Window? owner,
            string? text,
            string? caption,
            MessageBoxButtons buttons)
        {
            return ShowCore(owner, text, caption, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text and caption.
        /// </summary>
        public static DialogResult Show(IWin32Window? owner, string? text, string? caption)
        {
            return ShowCore(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        ///  Displays a message box with specified text.
        /// </summary>
        public static DialogResult Show(IWin32Window? owner, string? text)
        {
            return ShowCore(owner, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
        }

        private static DialogResult ShowCore(
            IWin32Window? owner,
            string? text,
            string? caption,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton)
        {
            var dialog = CreateM2TMessageBoxDialog(owner, text, caption, buttons, icon, defaultButton);
            var result = dialog.ShowDialog(owner);

            return result;
        }

        private static Form CreateM2TMessageBoxDialog(IWin32Window? owner, string? text, string? caption, 
            MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            var dialog = new M2TMessageBoxDialog()
            {
                Message = text ?? string.Empty,
                Text = caption ?? string.Empty,
            };
            var msgBoxButtons = GetMessageBoxButtons(buttons, defaultButton, true);
            dialog.AddButtons(msgBoxButtons);
            var focussedButtonIndex = defaultButton switch
            {
                MessageBoxDefaultButton.Button1 => 0,
                MessageBoxDefaultButton.Button2 => 1,
                MessageBoxDefaultButton.Button3 => 2,
                MessageBoxDefaultButton.Button4 => 3,
                _ => 0
            };
            if (msgBoxButtons.Length > focussedButtonIndex)
            {
                var focussedButton = msgBoxButtons[focussedButtonIndex];
                dialog.FocusButton(focussedButton);
            }
            return dialog;
        }

        private static M2TButton[] GetMessageBoxButtons(MessageBoxButtons buttons,
            MessageBoxDefaultButton defaultButton, bool useHighlightForDefaultButton)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    {
                        var okButton = CreateButton(NativeButtons.Ok, DialogResult.OK,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        return [okButton];
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        var okButton = CreateButton(NativeButtons.Ok, DialogResult.OK,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var cancelButton = CreateButton(NativeButtons.Cancel, DialogResult.Cancel,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        return [okButton, cancelButton];
                    }
                case MessageBoxButtons.YesNo:
                    {
                        var yesButton = CreateButton(NativeButtons.Yes, DialogResult.Yes,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var noButton = CreateButton(NativeButtons.No, DialogResult.No,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        return [yesButton, noButton];
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        var yesButton = CreateButton(NativeButtons.Yes, DialogResult.Yes,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var noButton = CreateButton(NativeButtons.No, DialogResult.No,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        var cancelButton = CreateButton(NativeButtons.Cancel, DialogResult.Cancel,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button3);
                        return [yesButton, noButton, cancelButton];
                    }
                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        var abortButton = CreateButton(NativeButtons.Abort, DialogResult.Abort,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var retryButton = CreateButton(NativeButtons.Retry, DialogResult.Retry,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        var ignoreButton = CreateButton(NativeButtons.Ignore, DialogResult.Ignore,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button3);
                        return [abortButton, retryButton, ignoreButton];
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        var retryButton = CreateButton(NativeButtons.Retry, DialogResult.Retry,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var cancelButton = CreateButton(NativeButtons.Cancel, DialogResult.Cancel,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        return [retryButton, cancelButton];
                    }
                case MessageBoxButtons.CancelTryContinue:
                    {
                        var cancelButton = CreateButton(NativeButtons.Cancel, DialogResult.Cancel,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button1);
                        var tryAgainButton = CreateButton(NativeButtons.TryAgain, DialogResult.TryAgain,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button2);
                        var continueButton = CreateButton(NativeButtons.Continue, DialogResult.Continue,
                            useHighlightForDefaultButton && defaultButton == MessageBoxDefaultButton.Button3);
                        return [cancelButton, tryAgainButton, continueButton];
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(buttons), buttons, "Invalid message box buttons specified.");
            }
        }

        private static M2TButton CreateButton(NativeButtons nativeButtonText, DialogResult dialogResult, bool useHighlightColor)
        {
            var localizedButtonText = NativeLocalizer.GetLocalizedString(nativeButtonText);
            var colorRole = useHighlightColor ? M2TButtonColorRoleSelection.Primary : M2TButtonColorRoleSelection.SurfaceContainer;
            return new M2TButton
            {
                Text = localizedButtonText,
                DialogResult = dialogResult,
                ColorRole = colorRole
            };
        }
    }
}
