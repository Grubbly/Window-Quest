# Windows User Auditing and File Permissions

It is almost guaranteed that during competition you will encounter a Windows machine
with Active Directory. Active Directory handles a large majority of domain controller activity esspecially when it comes to users and computers. This section of the lecture is tailored towards auditing domain users for validity and what to do when action needs to be taken on a user's account. 

**Domain** **Controller** (DC) - The primary server that handles security authentication requests in a domain. 

**Active** **Directory** (AD) - The service that authenticates and authorizes users, tracks groups, enforces security policies, and manages shared storage information. 

Topics:

* Creating users
* Creating groups
* Deleting users
* Deleting groups
* Disabling users
* Moving users to groups
* Fixing locked accounts
* Verifying accounts
* Password resets
* Organizational units (OUs)
* Shared folders
* Builtin
* Computers

## Event Viewer

Event viewer is where you will find entries for windows logs about various events. The level of detail and frequency of logs is dictated by policy settings in Group Policy.

**Group** **Policy** - Centralized management tool for application and user permissions.

```powershell
PS:\> GPUpdate /force
```

* Audit account management
* Audit logon events
* How values are deleted (database style)

## File Permissions

Windows uses access control lists (ACLs) to keep track of which users/groups are able to perform certain operation on a file or directory. Event viewer will only tell
you a file was handled, it will not give you specifics about the action taken (i.e. it will not tell you if a file was read, written, or executed). Therefore, when establishing permissions on a file, it is best practice to set only the modes that matter.
