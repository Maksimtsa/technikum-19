

void main(){
    Scanner input = new Scanner(System.in);
    Random r = new Random();

    int n = input.nextInt();
    n = n/2;
    ArrayList<Integer> nums = new ArrayList<>();

    for(int i = 0; i < n; i++){
        int j = r.nextInt(9);
        nums.add(j);
    }

    System.out.println(nums);
}