# Medicine Ordering System (MOS) 🏥💊

An engineering-focused e-commerce platform designed to help patients safely, securely, and efficiently order prescribed and over-the-counter medications online. The system bridges the gap between patients, local pharmacies, delivery networks, and healthcare databases.

## 🚀 Strategic Objectives
* **Accessibility:** Increase medication accessibility for elderly or visually impaired users through dynamic UI text sizing and screen reader support.
* **Efficiency:** Reduce in-store patient wait times and optimize delivery routes for drivers.
* **Safety:** Integrate automated e-prescription verification and pharmacist-led drug interaction checks to flag adverse health risks.

---

## 🛠️ Tech Stack & Architecture
* **Backend Logic:** C#.NET Framework
* **Database Management:** SQL Developer / SQL Server
* **Integrations:** National Drug Database, External Hospital E-Prescription APIs, and Third-Party Payment Gateways

---

## 📋 System Requirements

### 🔹 Functional Highlights
1. **User Authentication:** Secure login for patients to access personal dashboards.
2. **Smart Cart:** Temporarily stores over-the-counter and verified prescription medications.
3. **Prescription Verification:** Automatically cross-references uploaded prescription images with hospital databases.
4. **Drug Interaction Checker:** Flags potential risks between new orders and a patient's active medication profile.
5. **Real-Time Logistics:** Live map tracking with continuously updating ETAs for patients, paired with route optimization for delivery drivers.
6. **Automated Refill Reminders:** Calculates supply depletion dates for chronic disease patients and triggers push/email notifications.

### 🔹 Non-Functional Constraints
* **Reliability:** Guaranteed 99.9% uptime for critical medical access.
* **Performance:** Catalog queries return results in under 2.0 seconds.
* **Security:** Complete end-to-end encryption for sensitive medical histories and prescription images (at rest and in transit).

---

## 📊 System Design & UML Diagrams

### Use Case Diagram
*The system maps interactions across 5 core actors: Patients, Pharmacists, Delivery Drivers, the E-Prescription Database, and System Schedulers.*

### Core Order Workflow (Primary Flow)
1. **Selection:** Patient searches for medicine or uploads a physical prescription.
2. **Verification:** System automatically triggers an extension to validate the script against the E-Prescription registry.
3. **Safety Check:** Pharmacist reviews potential drug interactions simultaneously.
4. **Checkout:** Patient submits the order, strictly triggering the **Processing Payments** module through a third-party gateway.
5. **Fulfillment:** Upon successful authorization, a PDF receipt is issued, a tracking number is generated, and the delivery driver routing engine is notified.

---
## 📂 Repository Layout
```text
📂 Medicine-Ordering-System
 ├── 📂 Code              
 │    └── 📂 Medicine-Ordering-System  # Main VS Code project workspace
 ├── 📂 Database                       # SQL schemas, tables, and configuration scripts
 ├── 📂 Documentation                  # System Requirements (SRS) and UML diagrams
 └── 📄 README.md                      # Profile landing page
```
---
## 👥 Contributors 
* Jannah Mohamed Abdallah
* Fayrouz Sameh Salah
* Malak Yehia Nabil
* Sohaila Amr Yousry
* Nour Tamer Ahmed
* Maryam Ehab Abdelkader
