namespace LendSpace.Services
{
    public class DialogManager
    {
        public event Action? OnChange;
        public bool Show { get; private set; }
        public string? Title { get; private set; }
        public string? Message { get; private set; }
        private TaskCompletionSource<bool>? _tcs;

        public DialogManager()
        {
            Reset();
        }

        public void Reset()
        {
            Title = string.Empty;
            Message = string.Empty;
            Show = false;
            OnChange?.Invoke();
        }

        public Task<bool> ShowDialogAsync(string title, string message)
        {
            Title = title;
            Message = message;
            Show = true;
            _tcs = new TaskCompletionSource<bool>();

            NotifyStateChanged();

            return _tcs.Task;
        }

        public void Confirm(bool result)
        {
            Show = false;
            _tcs?.TrySetResult(result);

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
