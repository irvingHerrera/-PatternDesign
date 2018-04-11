namespace ObserverPattern.Inventario
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
