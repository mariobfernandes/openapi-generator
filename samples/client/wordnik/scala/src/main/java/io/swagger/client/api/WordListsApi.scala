package io.swagger.client.api

import io.swagger.client.model.WordList
import io.swagger.client.ApiInvoker
import io.swagger.client.ApiException

import java.io.File
import java.util.Date

import scala.collection.mutable.HashMap

class WordListsApi {
  var basePath: String = "http://api.wordnik.com/v4"
  var apiInvoker = ApiInvoker
  
  def addHeader(key: String, value: String) = apiInvoker.defaultHeaders += key -> value 

  
  def createWordList (body: WordList, auth_token: String)  = {
    // create path and map variables
    val path = "/wordLists.json".replaceAll("\\{format\\}","json")

    
    val contentType = {
      if(body != null && body.isInstanceOf[File] )
        "multipart/form-data"
      else "application/json"
      
      
    }

    // query params
    val queryParams = new HashMap[String, String]
    val headerParams = new HashMap[String, String]

    

    
    
    headerParams += "auth_token" -> auth_token
    

    try {
      apiInvoker.invokeApi(basePath, path, "POST", queryParams.toMap, body, headerParams.toMap, contentType) match {
        case s: String =>
           
        case _ => None
      }
    } catch {
      case ex: ApiException if ex.code == 404 => None
      case ex: ApiException => throw ex
    }
  }
  
}
