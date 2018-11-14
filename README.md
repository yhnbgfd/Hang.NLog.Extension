# Hang.NLog.Extension

nlog.config:
```
<nlog>
  <extensions>
    <add assembly="Hang.NLog.Extension"/>
  </extensions>
</nlog>
```

code:
```
RaiseEventTarget.WriteEvent += (s, e) =>
{
  //do something
};
```
