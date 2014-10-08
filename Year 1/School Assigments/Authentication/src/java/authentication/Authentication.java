/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package authentication;

import java.util.HashMap;
import java.util.Map;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;

/**
 *
 * @author Michael Fesser
 */
@WebService(serviceName = "Authentication")
public class Authentication {

    private HashMap<String, String> userCredentials = new HashMap();

    public Authentication() {
        userCredentials.put("bjmaclean", "pwbjmaclean");
        userCredentials.put("test", "pwtest");
        userCredentials.put("jdoe", "pwjdoe");
    }

    private boolean authenticated;

    /**
     * Web service operation
     */
    @WebMethod(operationName = "authenticate")
    public boolean authenticate(@WebParam(name = "username") String username, @WebParam(name = "password") String password) {
        authenticated = false;
        for (Map.Entry<String, String> entry : userCredentials.entrySet()) {
            if (username.equals(entry.getKey())) {
                if (password.equals(entry.getValue())) {
                    authenticated = true;
                }
            }
        }
        return authenticated;
    }
}
