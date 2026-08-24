class Lasagna
{
    public int ExpectedMinutesInOven() {
        return 40;
    }

    public int RemainingMinutesInOven(int expectedTime) {
        int remainTime = ExpectedMinutesInOven() - expectedTime;
        return remainTime;
    }

    public int PreparationTimeInMinutes(int layers) {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int ovenTime) {
        int prepTime = PreparationTimeInMinutes(layers);
        return prepTime + ovenTime;
    }
}
