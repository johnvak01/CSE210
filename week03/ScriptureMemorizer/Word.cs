public class Word{
    private     string  _content;
    private     bool    _visibility;
    
    public Word(string content){
        _content = content;
        _visibility = true;
    }
    public void ToggleVisibility(){
        if(_visibility){
            _visibility = false;
        }else{
            _visibility = true;
        }
    }
    public string GetContent(){
        if(_visibility){
            return _content;
        }else{
            string hiddenString = "";
            for(int x = 0; x < _content.Length; x++){
                hiddenString+="_";
            }
            return hiddenString;
        }
    }
    public bool GetVisibility(){
        return _visibility;
    }
}