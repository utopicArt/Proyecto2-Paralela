package recorder;
import java.io.File;
import java.util.Vector;
import javax.media.MediaLocator;
import java.awt.Dimension;
import java.awt.Toolkit;

/**
 * @author: JC MOUSE vía jc-mouse.net
 * url:     https://www.jc-mouse.net/java/convertir-imagenes-jpeg-a-video-mov
 * Desc:    Convierte imagenes a video.
 */
public class videoTransform {
    static JpegImagesToMovie imageToMovie = new JpegImagesToMovie();
    String outputFile = "video.mp4",
           directory;
    int screenWidth,
        screenHeight;    
    
    public videoTransform(String path){
        this.directory = path;
        Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
        this.screenWidth = (int) screenSize.getWidth();
        this.screenHeight =(int) screenSize.getHeight();
    }

    public void createVideo() {

        Vector<String> imgLst = new Vector<String>();  
        //se leen todas las imagenes de la direccion dada y se colocan en el Vector imgLst
        File folder = new File( directory );
        System.out.println("Obteniendo imagenes de: " + this.directory);
        File[] listOfFiles = folder.listFiles();
        System.out.println( "Imagenes JPEG: " + listOfFiles.length );
        for (int i = listOfFiles.length-1; i >=0 ; i--) {
            imgLst.add( listOfFiles[i].getAbsolutePath() );        
        }
        // 
        MediaLocator oml;
        if ((oml = imageToMovie.createMediaLocator( outputFile )) == null)
        {
            System.err.println("No se puede construir media locator de: " + outputFile);
            System.exit(0);
        }

        //Ancho, alto, FPS, lista de imagenes, MediaLocator
        imageToMovie.doIt(screenWidth, screenHeight, 15, imgLst, oml);
    }

}
