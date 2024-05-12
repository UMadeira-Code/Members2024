using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Dialog;

namespace Members.Client.Shared
{
    public partial class PromptDialog
    {
        [CascadingParameter]
        MudDialogInstance? MudDialog { get; set; }

        [Parameter]
        public string Title { get; set; } = "Dialog";

        [Parameter]
        public string Label { get; set; } = string.Empty;

        [Parameter]
        public string Value { get; set; } = string.Empty;

        private void OnOk()
        {
            // Close the dialog (you can also pass data back if needed)
            MudDialog?.Close( DialogResult.Ok( Value ) );
        }

        private void OnCancel()
        {
            // Close the dialog (you can also pass data back if needed)
            MudDialog?.Close( DialogResult.Cancel() );
        }
    }
}
