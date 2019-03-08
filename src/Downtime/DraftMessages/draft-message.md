## Overview:
This is to notify affected parties of changes to the Medidata FTP services   


## Maintenance Description:
The minimum encryption standards (TLS 1.2 or later, AES-128 or better and SHA-256 or better) defined by Information Security to secure communications with Medidata's FTP and EDI services will be changed and may require client action to accept the new standards. The update will incur no downtime to affect the change but if action is required by the end user, their client application will not allow data transfers until they have done so. 

The certificate used by the EDI services will change to one issued by Entrust.

A notification was distributed to all EDI clients several times since June 2018 and was posted to the client support site regarding this change and several others as well: https://support.mdsol.com/hc/en-us/articles/360000350567-TLS-1-2-Entrust-Certificate-FTP-Update-7-12-2018.

This change will only affect users of the AS2 and FTP protocols from clients located outside of the Houston Data Center. It will not affect connections from our hosted applications that use SMB rather than AS2 or FTP.


## Maintenance Date:
September 29, 2018 (Saturday)


## Maintenance Window:
12:00 PM to 4:00 PM US/Central (EU hosting)

6:00 PM to 10:00 PM US/Central (US hosting)



## Action:
Notify Affected Clients of the change.


## Technical Questions/Inquiries:
- Brett Marlowe
- Raul Ortega


## Affected URLs and Products:
- ftp01.ftp.mdsol.com
- ftp02.ftp.mdsol.com
- ftp03.ftp.mdsol.com
- ftp07.ftp.mdsol.com
- ftp08.ftp.mdsol.com
- interchange01.edi.mdsol.com
- interchange02.edi.mdsol.com
- interchange03.edi.mdsol.com
- interchange04.edi.mdsol.com