package com;

import java.io.ByteArrayOutputStream;
import java.io.ObjectOutputStream;
import java.util.Base64;
import java.io.IOException;
import java.util.zip.GZIPOutputStream;

public class genSignatures {
    
    public static void main (String[] args) {
    
        try {
            testObject to1 = new testObject();
        
            ByteArrayOutputStream bytes = new ByteArrayOutputStream();
            ObjectOutputStream objStream = new ObjectOutputStream(bytes);
            objStream.writeObject(to1);
            objStream.close();
        
            System.out.println("ascii: "+bytes.toByteArray().toString());
            System.out.println("base64: "+Base64.getEncoder().encodeToString(bytes.toByteArray()));
            
            GZIPOutputStream gzipOutputStream = new GZIPOutputStream(bytes);
            gzipOutputStream.write(bytes.toByteArray());
            System.out.println("gzip ascii : "+bytes.toByteArray().toString());
            System.out.println("gzip base64 : "+Base64.getEncoder().encodeToString(bytes.toByteArray()));
            
            
        } catch (IOException e) {
            System.out.println("exception: "+e.getMessage());
        }
    }
}
