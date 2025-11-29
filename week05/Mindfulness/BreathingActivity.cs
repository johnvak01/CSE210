public class BreathingActivity : Activity{
    public BreathingActivity():base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){
        
        return;
    }
    public void Breathing(){
        Console.Write("Get Ready.");
        this.Countdown(3);
        
        bool breath = true;
        int countdownTime = _duration;
        while(countdownTime > 0){
            Console.Clear();
            if(breath){
                breath = false;
                Console.Write("Breath In. ");
            }
            else{
                breath = true;
                Console.Write("Breath Out. ");
            }
            if(countdownTime < 4){
                this.Countdown(countdownTime);
                countdownTime = 0;
            }else{
                this.Countdown(4);
                countdownTime -= 4;
            }
        }
        Console.Clear();
    }
}