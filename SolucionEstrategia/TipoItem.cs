namespace SolucionEstrategia
{
    public class TipoItem : ITipoItem
    {
        IUpdateBehavior ibehavior;
        public TipoItem(IUpdateBehavior ibehavior)
        {
            this.ibehavior = ibehavior;
        }
        public void Actualizar(Item item)
        {
            ibehavior.UpdateQuality(item);
        }
    }
}
