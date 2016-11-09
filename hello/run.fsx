#r "System.Net.Http.dll"

open System
open System.IO
open System.Net
open System.Net.Http

type Message = { msg : string }

let Run (req:HttpRequestMessage, log:TraceWriter) =
    req.CreateResponse(HttpStatusCode.OK, { msg = "hello" })
