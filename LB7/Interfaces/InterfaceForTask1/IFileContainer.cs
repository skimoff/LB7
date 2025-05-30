namespace LB7;

public interface IFileContainer:IContainer
{
    void Save( String fileName );
    void Load( String fileName );
    Boolean IsDataSaved {get;}
}