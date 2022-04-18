namespace Claims2.App.Data
{
    public class StateContainer
    {
        private Object? savedObj;

        public Object Property
        {
            get => savedObj;
            set
            {
                savedObj = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
