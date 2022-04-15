# OculusPanopticon
Beginning VRWorlds Browser for Oculus (and generally for OpenXR)

Getting the browser started.   Got kafka client working (redpanda).
No luck at all with grpc though I did get protobuf to work.   Might do that API
with websockets, though signalr is a possible option.

Initial emphasis will be remote telework objects such as vt100 terminals, vnc and possibly rdp.
No great possibily of getting smart objects to work since wasmtime moved the goalposts on me.
Once unity got to netstandard2.1 (which wasmtime targetted) they pushed it up to .net6.
So the smart objects (emissaries) will have to run on the server intially and the rpc calls implemented on the actual client will have to be very standardized and rote.

The support code for this is in the PanopticonVR repository.   
