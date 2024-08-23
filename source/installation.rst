=============
Installation
=============

This section provides instructions on how to set up and install MyApiProject.

Prerequisites
=============

Before you begin, ensure you have met the following requirements:

- **.NET Core SDK**: Download and install from [Microsoft's official site](https://dotnet.microsoft.com/download).
- **Python 3.x**: Download and install from [Python's official site](https://www.python.org/downloads/).
- **Sphinx**: Install using pip:

  .. code-block:: bash

     pip install sphinx

- **MikTeX (Windows)** or **TeX Live (Linux/macOS)**: Required for PDF documentation generation.

Steps to Install
================

Follow these steps to set up and install MyApiProject:

1. **Clone the Repository**:

   .. code-block:: bash

      git clone https://github.com/your-username/MyApiProject.git
      cd MyApiProject

2. **Restore .NET Dependencies**:

   .. code-block:: bash

      dotnet restore

3. **Set Up Python Environment** (Optional):

   It's recommended to use a virtual environment:

   .. code-block:: bash

      python -m venv .venv
      source .venv/bin/activate  # On Windows use `.venv\Scripts\activate`

   Install the required Python packages:

   .. code-block:: bash

      pip install -r requirements.txt

4. **Verify Installation**:

   Make sure everything is installed correctly by running:

   .. code-block:: bash

      dotnet run

   The API should now be running at `http://localhost:5000`.

Next Steps
==========

- Once the installation is complete, you can start using the API.
- See the :doc:`usage` section for detailed usage instructions.
