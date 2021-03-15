package ypl;
import java.awt.*;
import java.awt.image.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.geom.Arc2D;
import java.awt.geom.Line2D;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.Writer;
import java.util.LinkedList;
import java.util.Random;
import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
import java.util.Queue; 

public class yl2pr3 extends JFrame implements ActionListener {
 
    
   
    
	
    public static ImageIcon arplan;
    private static Graphics2D gr;
    private static JFrame f;
    private static JPanel p;
    public static JLabel plan,sayi,ilk,max,son,capas,kenar;
    private static JTextField metin1,metin2,metin3,metin4,metin5,metin6;
    private static JButton devam,ekle;
    private static String a,b,c,line;
	static String[] s;
    private static int dizi[][],dizi1[][],dizi2[][];
	static int a1,b1,c1,i,j,sayac,gec=0,ran,gc=0,ast,best;
	static File file;
    
    
    public static void main(String[] args) {
    	file = new File("dosya.txt");
		
    	if(file.exists()) {
       	 file.delete();
       	 try {
				file.createNewFile();
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
        }
	
    	
	f=new JFrame("HAVUZ");
	f.setSize(1000,600);
	f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
   
    
	p= new JPanel();
	p.setLayout(null);
	
	arplan=new ImageIcon("123.jpg");
	plan=new JLabel(arplan);
	plan.setSize(1000,600);	
	
	sayi = new JLabel("Musluk Sayisi");
    sayi.setForeground(Color.black);
    sayi.setBounds(65, 80, 125, 25);
    max=new JLabel("(Max 10)");
    max.setForeground(Color.black);
    max.setBounds(65, 95, 125, 25);
    metin1= new JTextField();
    metin1.setBackground(Color.white);
    metin1.setBounds(165, 80, 125, 25);

    ilk = new JLabel("Ilk musluk");
    ilk.setForeground(Color.black);
    ilk.setBounds(65, 130, 125, 25);

    metin2= new JTextField();
    metin2.setBackground(Color.white);
    metin2.setBounds(165, 130, 125, 25);
  
    
    son = new JLabel("son musluk");
    son.setForeground(Color.black);
    son.setBounds(65, 180, 125, 25);
    
    metin3= new JTextField();
    metin3.setBackground(Color.white);
    metin3.setBounds(165, 180, 125, 25);
    
    ekle=new JButton("Ekle");
    ekle.setBackground(Color.cyan);
    ekle.setBounds(160, 330, 70, 30);

    capas = new JLabel("Kenarlar", HEIGHT); 
    capas.setForeground(Color.black);
    capas.setBounds(65, 230, 125, 25);
    
    metin4= new JTextField();
    metin4.setBackground(Color.white);
    metin4.setBounds(165, 230, 25, 25);
    
    metin5= new JTextField();
    metin5.setBackground(Color.white);
    metin5.setBounds(205, 230, 25, 25);
    
    kenar = new JLabel("Kapasite", HEIGHT); 
    kenar.setForeground(Color.black);
    kenar.setBounds(65, 280, 125, 25);
    
    metin6= new JTextField();
    metin6.setBackground(Color.white);
    metin6.setBounds(165, 280, 125, 25);
    
    
    devam = new JButton("Devam");
    devam.setBackground(Color.LIGHT_GRAY);
    devam.setBounds(350, 400, 90, 50);
    
    f.setContentPane(p);
    f.setResizable(false);
    f.setVisible(true);
    plan.getBaseline(15, 10);
    
     p.add(ekle);
     p.add(max);
    p.add(sayi);
    p.add(ilk);
    p.add(kenar);
    p.add(metin1);
    p.add(metin2);
    p.add(metin3);
    p.add(metin4);
    p.add(metin5);
    p.add(metin6);
    p.add(son);
    p.add(capas);
    p.add(devam);
    p.add(plan);
	   
  
   ekle.addActionListener(new ActionListener() 
    { 
     
    	public void actionPerformed(ActionEvent e) 
    	{
    	a=metin4.getText();
    	b=metin5.getText();
    	c=metin6.getText();
    		
    		
    		
    		
    		
             
            FileWriter fileWriter = null;
			try {
				fileWriter = new FileWriter(file,true);
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		       BufferedWriter bWriter = new BufferedWriter(fileWriter);
		    
            try {
				bWriter.write(a+" "+b+" "+c+"\n");
				sayac++;
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
           
            try {
				bWriter.close();
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
    	
    	
    	} 
     
    }); 


   devam.addActionListener(new ActionListener() 
    { 
     
    	public void actionPerformed(ActionEvent e) 
    	{ 
    	a=metin1.getText();//sayi
    	b=metin2.getText();//ilk
    	c=metin3.getText();//son

    	a1=Integer.parseInt(a);
    	b1=Integer.parseInt(b);
    	c1=Integer.parseInt(c);
           
    
	try {
		diziyeat();
	} catch (IOException e1) {
		// TODO Auto-generated catch block
		e1.printStackTrace();
	}

    	}
      
    }); 


   
   
   
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
	
		// TODO Auto-generated method stub
		
	}
	
	
	public yl2pr3() {
		 this.setSize(1000,600);
	        this.setTitle("Sekil");
	        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	        this.add(new ciz(),BorderLayout.CENTER);
	        this.setVisible(true);
		
	
	}
private class ciz extends JComponent
{
	public void paint(Graphics g) {
		dizi=new int[10][3];
		dizi[0][0]=120;//bas
		dizi[0][1]=250;
		 
		
		dizi[1][0]=170;
		dizi[1][1]=150;
		 
		
		dizi[2][0]=170;
		dizi[2][1]=350;///////////
		 
		
		dizi[3][0]=300;
		dizi[3][1]=100;
		 
		
		dizi[4][0]=300;
		dizi[4][1]=400;
		 
		dizi[5][0]=400;////////
		dizi[5][1]=100;
		 
		
		dizi[6][0]=400;//////////
		dizi[6][1]=400;
		 
		
		dizi[7][0]=530;
		dizi[7][1]=150;
		 
		
		dizi[8][0]=530;
		dizi[8][1]=350;
		 
		
		dizi[9][0]=580;//son////////
		dizi[9][1]=250;
		for(i=0;i<10;i++) {
			
			dizi[i][2] = (int)(Math.random()*10+1);

		    for (int j = 0; j < i; j++) {
		        if (dizi[i][2] == dizi[j][2]) {
		            i--;
		            break;
		        }
		    }  
		
		}

		
		for(i=0;i<10;i++) {
		
			if(dizi[i][2]==b1) {
				gc=dizi[0][2];
				dizi[0][2]=dizi[i][2];
				dizi[i][2]=gc;
			
				
			}
			else if(dizi[i][2]==c1) {
			
				gec=dizi[a1-1][2];
				dizi[a1-1][2]=dizi[i][2];
				dizi[i][2]=gec;
				}
			
		}
		
		for(i=0;i<10;i++) {
			//System.out.print("  "+dizi[i][2]);
		}
		
		
		gr=(Graphics2D)g;
		gr.setRenderingHint(RenderingHints.KEY_ANTIALIASING,RenderingHints.VALUE_ANTIALIAS_ON);
	       
		try {
			BufferedImage image = ImageIO.read(new File("123.jpg")); 
			gr.drawImage(image, -70, -10, null);
			
			

			gr.setColor(Color.red);
			for(i=0;i<a1;i++) {
				ast=dizi[i][2];
				gr.fillOval(dizi[ast-1][0], dizi[ast-1][1],10,10);
				if(dizi[i][2]%2==0) {
				gr.drawString(i+1+".musluk",dizi[ast-1][0], dizi[ast-1][1]-20);
			
		} else {
			gr.drawString(i+1+".musluk",dizi[ast-1][0], dizi[ast-1][1]+30);
		}
			}
			
			
			for(i=0;i<dizi1.length;i++) { 
				
				ast=dizi[dizi1[i][0]-1][2];
				best=dizi[dizi1[i][1]-1][2];
				
				gr.drawLine(dizi[ast-1][0],dizi[ast-1][1],dizi[best-1][0],dizi[best-1][1]);
				
				
				
				
				
				
			
			}
			
			
			 
			
			
			
			
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		 
		
    	    
	}
}
	public static void diziyeat() throws IOException {
		dizi1=new int [sayac][sayac];
		file=new File("dosya.txt");
		 FileReader fileReader = new FileReader(file);
	

		
	    

	     BufferedReader br = new BufferedReader(fileReader);

	     while ((line = br.readLine()) != null) {
	               s=line.split(" ");
	                
	     dizi1[i][0]=Integer.parseInt(s[0]);
	     dizi1[i][1]=Integer.parseInt(s[1]);
	     dizi1[i][2]=Integer.parseInt(s[2]);
	     i++;
	     }
          dizi2=new int[a1][a1];
	     br.close(); 
	     for(i=0;i<dizi1.length;i++){
	    	 
	    	 dizi2[dizi1[i][0]-1][dizi1[i][1]-1]=dizi1[i][2];
	    	 }
	     
	     new yl2pr3();
	      

	    
	     minCut(dizi2, b1-1, c1-1); 
	     
	    
	

	
}

private static boolean bfs(int[][] rGraph, int s, 
       int t, int[] parent) { 
	
	
	boolean[] visited = new boolean[rGraph.length]; 
	
	
	Queue<Integer> q = new LinkedList<Integer>(); 
	q.add(s); 
	visited[s] = true; 
	parent[s] = -1; 
	
	 
	while (!q.isEmpty()) { 
		int v = q.poll(); 
		for (int i = 0; i < rGraph.length; i++) { 
			if (rGraph[v][i] > 0 && !visited[i]) { 
				q.offer(i); 
				visited[i] = true; 
				parent[i] = v; 
			} 
		} 
	} 
		 
	return (visited[t] == true); 
} 


private static void dfs(int[][] rGraph, int s, 
	boolean[] visited) { 
	visited[s] = true; 
	for (int i = 0; i < rGraph.length; i++) { 
			if (rGraph[s][i] > 0 && !visited[i]) { 
				dfs(rGraph, i, visited); 
			} 
	} 
} 


private static void minCut(int[][] graph, int s, int t) { 
	int u,v,pathFlow = 0,maxt = 0; 
	
	int[][] rGraph = new int[graph.length][graph.length]; 
	for (int i = 0; i < graph.length; i++) { 
		for (int j = 0; j < graph.length; j++) { 
			rGraph[i][j] = graph[i][j]; 
		} 
	} 

	
	int[] parent = new int[graph.length]; 
		 
	while (bfs(rGraph, s, t, parent)) { 
		
	
		pathFlow = Integer.MAX_VALUE;		 
		for (v = t; v != s; v = parent[v]) { 
			u = parent[v]; 
			pathFlow = Math.min(pathFlow, rGraph[u][v]); 
		} 
		
		
		for (v = t; v != s; v = parent[v]) { 
			u = parent[v]; 
			rGraph[u][v] = rGraph[u][v] - pathFlow; 
			rGraph[v][u] = rGraph[v][u] + pathFlow; 
		} 
		maxt+=pathFlow;
	} 
	
	System.out.println("maximum akýþ kapasitesi:"+maxt);
	
	boolean[] isVisited = new boolean[graph.length];	 
	dfs(rGraph, s, isVisited); 
	
	System.out.print("su akýþýný kesmek için kapatýlacak musluklar: ");
	for (int i = 0; i < graph.length; i++) { 
		for (int j = 0; j < graph.length; j++) { 
			if (graph[i][j] > 0 && isVisited[i] && !isVisited[j]) { 
				System.out.println((i+1)+" - "+(j+1)); 
			} 
		} 
	} 
} 	 


} 